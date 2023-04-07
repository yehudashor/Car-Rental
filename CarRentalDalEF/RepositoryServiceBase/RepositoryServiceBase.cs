﻿using DalApi.IEntity;
using DalApi.IRepositoryService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace RepositoryServiceBase;

public class RepositoryServiceBase<TEntity, TDBContext> : IRepositoryService<TEntity>
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
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            DbSet<TEntity> entities = dBContext.Set<TEntity>();
            IQueryable<TEntity> entitiesResult = filter is null ? entities.Select(e => e) : entities.Where(filter);

            foreach (var includeProperty in includeProperties)
            {
                entitiesResult = entitiesResult.Include(includeProperty);
            }
            return await entitiesResult.ToListAsync();
        }
    }

    public async Task Reference(TEntity entity, params Expression<Func<TEntity, object>>[] loadObjects)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            EntityEntry<TEntity> entityEntry = dBContext.Entry(entity);

            foreach (var loadObject in loadObjects)
            {
                await entityEntry.Reference(loadObject).LoadAsync();
            }
        }
    }

    public async Task Collection(TEntity entity, params Expression<Func<TEntity, IEnumerable<object>>>[] loadObjectsCollection)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            EntityEntry<TEntity> entityEntry = dBContext.Entry(entity);

            foreach (var loadObjectCollection in loadObjectsCollection)
            {
                await entityEntry.Collection(loadObjectCollection).LoadAsync();
            }
        }
    }
}