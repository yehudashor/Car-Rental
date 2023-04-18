using System.Linq.Expressions;

namespace CarRentalDalCore.DalApi.IEntityService;

public interface IEntityService<TEntity> where TEntity : class, IEntity.IEntity, new()
{
    Task Add(TEntity entity);
    Task AddRange(params TEntity[] entities);
    Task Delete(Expression<Func<TEntity, bool>> filter);
    Task Update(TEntity entity);
    Task<TEntity> Get(Expression<Func<TEntity, bool>> filter,
        params Expression<Func<TEntity, object>>[] includeProperties);
    Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null,
        Expression<Func<TEntity, object>> sort = null,
        params Expression<Func<TEntity, object>>[] includeProperties);
    Task LoadObjects(TEntity entity, params Expression<Func<TEntity, object>>[] loaDataObjectsbjects);

    Task<bool> Any(Expression<Func<TEntity, bool>> anyMatch);
    Task<bool> All(Expression<Func<TEntity, bool>> checkAll);
    Task<long> Count(Expression<Func<TEntity, bool>> count);
}
