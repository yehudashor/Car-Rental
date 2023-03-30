using CarRentalDalCore.DalApi.ICrud;
using DalApi.IEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace CarRentalDalEF.CrudBase;

public class EFCrudBase<TEntity, TDBContext> : ICrud<TEntity>
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

    public async Task Delete(Expression<Func<TEntity, bool>> func)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            dBContext.Remove(func);
            await dBContext.SaveChangesAsync();
        }
    }

    public async Task<TEntity> Get(Expression<Func<TEntity, bool>> func)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            TEntity entity = await dBContext.Set<TEntity>().FindAsync(func);
            return entity;
        }
    }

    public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> func)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            IEnumerable<TEntity> entities = await dBContext.Set<TEntity>().Where(func).ToListAsync();
            return entities;
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
}
