using DalApi.IEntity;
using System.Linq.Expressions;

namespace CarRentalDalCore.DalApi.ICrud;

public interface ICrud<TEntity> where TEntity : class, IEntity, new()
{
    Task Add(TEntity entity);
    Task Delete(Expression<Func<TEntity, bool>> filter);
    Task Update(TEntity entity);
    Task<TEntity> Get(Expression<Func<TEntity, bool>> filter);
    Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null,
        params Expression<Func<TEntity, object>>[] includeProperties);

}
