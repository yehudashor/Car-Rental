using CarRentalDalCore.DalApi.IEntity;
using CarRentalDalCore.DalApi.IEntityService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace CarRentalDalEF.EntityServiceBase;

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

    public async Task AddRange(params TEntity[] entities)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            await dBContext.AddRangeAsync(entities);
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

    public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter,
         params Expression<Func<TEntity, object>>[] includeProperties)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            TEntity entity = await dBContext.Set<TEntity>().FindAsync(filter);

            return entity;
        }
    }

    public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null,
        Expression<Func<TEntity, object>> sort = null,
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

            entities = addIncludeProperties(includeProperties, entities);

            return await entities.ToListAsync();
        }
    }

    private IQueryable<TEntity> addIncludeProperties(Expression<Func<TEntity, object>>[] includeProperties, IQueryable<TEntity> entities) =>

         includeProperties.Aggregate(entities, (entitiesResult, includeProperty) => entitiesResult.Include(includeProperty));


    public async Task LoadObjects(TEntity entity, params Expression<Func<TEntity, object>>[] loaDataObjectsbjects)
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

    public async Task<bool> Any(Expression<Func<TEntity, bool>> anyMatch)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            return await dBContext.Set<TEntity>().AnyAsync(anyMatch);
        }
    }

    public async Task<bool> All(Expression<Func<TEntity, bool>> checkAll)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            return await dBContext.Set<TEntity>().AllAsync(checkAll);
        }
    }

    public async Task<long> Count(Expression<Func<TEntity, bool>> count)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            return await dBContext.Set<TEntity>().CountAsync(count);
        }
    }
}
