using System.Linq.Expressions;

namespace DalApi.IEntityService;

public interface IEntityService<TEntity> where TEntity : class, IEntity.IEntity, new()
{
    Task Add(TEntity entity);
    Task Delete(Expression<Func<TEntity, bool>> filter);
    Task Update(TEntity entity);
    Task<TEntity> Get(Expression<Func<TEntity, bool>> filter);
    Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null,
        Expression<Func<TEntity, TEntity>> sort = null,
        params Expression<Func<TEntity, object>>[] includeProperties);
    Task LoadObject(TEntity entity, params Expression<Func<TEntity, object>>[] loaDataObjectsbjects);
    Task LoadCollection(TEntity entity, params Expression<Func<TEntity, IEnumerable<object>>>[] loaDataObjectsbjectsCollection);
}
