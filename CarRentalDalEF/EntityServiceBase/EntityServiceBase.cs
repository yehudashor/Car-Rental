using DalApi.IEntity;
using DalApi.IEntityService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace EntityServiceBase;

public class EntityServiceBase<TEntity, TDBContext> : IEntityService<TEntity>
    where TEntity : class, IEntity, new()
    where TDBContext : DbContext, new()
{
    public async Task Add(TEntity entity)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            await dBContext.AddAsync(entity);
            await dBContext.SaveChangesAsync();
        }
    }

    public async Task Delete(Expression<Func<TEntity, bool>> filter)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            dBContext.Remove(filter);
            await dBContext.SaveChangesAsync();
        }
    }

    public async Task Update(TEntity entity)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            dBContext.Update(entity);
            await dBContext.SaveChangesAsync();
        }
    }

    public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            TEntity entity = await dBContext.Set<TEntity>().FindAsync(filter);
            return entity;
        }
    }

    public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null,
        Expression<Func<TEntity, TEntity>> sort = null,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            IQueryable<TEntity> entities = dBContext.Set<TEntity>().AsQueryable();

            if (filter is not null)
            {
                entities = entities.Where(filter);
            }

            if (sort is not null)
            {
                entities = entities.OrderBy(sort);
            }

            foreach (var includeProperty in includeProperties)
            {
                entities = entities.Include(includeProperty);
            }

            return await entities.ToListAsync();
        }
    }

    public async Task LoadObject(TEntity entity, params Expression<Func<TEntity, object>>[] loaDataObjectsbjects)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            EntityEntry<TEntity> entityEntry = dBContext.Entry(entity);

            foreach (var loaDataObjectsbject in loaDataObjectsbjects)
            {
                await entityEntry.Reference(loaDataObjectsbject).LoadAsync();
            }
        }
    }

    public async Task LoadCollection(TEntity entity, params Expression<Func<TEntity, IEnumerable<object>>>[] loaDataObjectsbjectsCollection)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            EntityEntry<TEntity> entityEntry = dBContext.Entry(entity);

            foreach (var loaDataObjectsbjectCollection in loaDataObjectsbjectsCollection)
            {
                await entityEntry.Collection(loaDataObjectsbjectCollection).LoadAsync();
            }
        }
    }
}
