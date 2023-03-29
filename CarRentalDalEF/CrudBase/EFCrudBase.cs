using CarRentalDalCore.DalApi;
using DalApi.IEntity;
using Microsoft.EntityFrameworkCore;

namespace CarRentalDalEF.CrudBase;



public class EFCrudBase<TEntity, TDBContext> : ICrud<TEntity>
    where TEntity : class, IEntity, new()
    where TDBContext : DbContext, new()
{
    public void Add(TEntity entity)
    {
        using (TDBContext dBContext = new TDBContext())
        {
            dBContext.Add(entity);
            dBContext.SaveChanges();
        }
    }

    public void Delete(Func<TEntity, bool> func)
    {
        throw new NotImplementedException();
    }

    public TEntity Get(Func<TEntity, bool> func)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TEntity> GetAll(Func<TEntity, bool> func)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
