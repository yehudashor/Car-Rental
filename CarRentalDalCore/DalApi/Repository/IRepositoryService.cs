using System.Linq.Expressions;

namespace DalApi.IRepositoryService;

public interface IRepositoryService<TEntity> where TEntity : class, IEntity.IEntity, new()
{
    Task Add(TEntity entity);
    Task Delete(Expression<Func<TEntity, bool>> filter);
    Task Update(TEntity entity);
    Task<TEntity> Get(Expression<Func<TEntity, bool>> filter);
    Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null,
        params Expression<Func<TEntity, object>>[] includeProperties);

    Task Reference(TEntity entity, params Expression<Func<TEntity, object>>[] loadObjects);

    Task Collection(TEntity entity, params Expression<Func<TEntity, IEnumerable<object>>>[] loadObjectsCollection);
}
