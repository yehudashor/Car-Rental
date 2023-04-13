using System.Linq.Expressions;

namespace DalApi.IEntityService;

public interface IEntityService<TEntity> where TEntity : class, IEntity.IEntity, new()
{
    Task Add(TEntity entity);
    Task Delete(Expression<Func<TEntity, bool>> filter);
    Task Update(TEntity entity);
    Task<TEntity> Get(Expression<Func<TEntity, bool>> filter,
        params Expression<Func<TEntity, object>>[] includeProperties);
    Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null,
        Expression<Func<TEntity, object>> sort = null,
        params Expression<Func<TEntity, object>>[] includeProperties);
    Task LoadObjects(TEntity entity, params Expression<Func<TEntity, object>>[] loaDataObjectsbjects);

    Task<bool> Any(Expression<Func<TEntity, bool>> any_match);
    Task<bool> All(Expression<Func<TEntity, bool>> check_all);
    Task<int> Count(Expression<Func<TEntity, bool>> sum);
}
