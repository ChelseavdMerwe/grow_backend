using System.Collections.Generic;
using System.Threading.Tasks;

namespace grow_api_v1.Repository;


public interface IBaseRepository<TEntity, Tkey>
{
    Task CreateAsync(TEntity obj);

    Task AddRangeAsync(List<TEntity> objs);

    void UpdateRange(List<TEntity> objs);

    bool Update(TEntity obj);

    Task<List<TEntity>> GetAll();

    Task<TEntity> Get(Tkey Id);

    void Delete(TEntity obj);

    void DeleteRange(List<TEntity> objs);

    Task<int> SaveAsync();

    int Count();
}