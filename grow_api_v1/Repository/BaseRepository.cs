using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using grow_api_v1.Constants.Errors;
using grow_api_v1.Exceptions;
using grow_api_v1.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace grow_api_v1.Repository;

public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : BaseModel<TKey>
    {
        private readonly Microsoft.EntityFrameworkCore.DbContext _context;
        private readonly DbSet<TEntity> _entitySet;

        public BaseRepository(Microsoft.EntityFrameworkCore.DbContext dbContext)
        {
            _context = dbContext;
            _entitySet = dbContext.Set<TEntity>();
        }

        public async Task CreateAsync(TEntity obj)
        {
            await _entitySet.AddAsync(obj);
            return;
        }

        public async Task AddRangeAsync(List<TEntity> objs)
        {
            await _entitySet.AddRangeAsync(objs);
            return;
        }

        public void UpdateRange(List<TEntity> objs)
        {
            _entitySet.UpdateRange(objs);
            return;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _entitySet.ToListAsync();
        }

        public async Task<TEntity> Get(TKey id)
        {
            return await _entitySet
                .Where(e => e.Id.Equals(id))
                .SingleOrDefaultAsync();
        }

        public void Delete(TEntity obj)
        {
            _entitySet.Remove(obj);
            return;
        }

        public void DeleteRange(List<TEntity> objs)
        {
            _entitySet.RemoveRange(objs);
            return;
        }

        public async Task<int> SaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new DatabaseException(e, DatabaseErrors.FailedToSave);
            }
        }

        public bool Update(TEntity obj)
        {
            return _entitySet.Update(obj) != null;
        }

        public int Count()
        {
            return _entitySet.Count();
        }   
}