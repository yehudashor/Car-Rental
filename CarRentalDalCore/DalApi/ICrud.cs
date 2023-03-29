using DalApi.IEntity;

namespace CarRentalDalCore.DalApi;

public interface ICrud<TEntity> where TEntity : class, IEntity, new()
{
    void Add(TEntity entity);
    void Delete(Func<TEntity, bool> func);
    void Update(TEntity entity);
    TEntity Get(Func<TEntity, bool> func);
    IEnumerable<TEntity> GetAll(Func<TEntity, bool> func);

}
