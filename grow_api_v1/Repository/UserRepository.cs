using System;
using System.Linq;
using System.Threading.Tasks;
using grow_api_v1.Models;
using grow_api_v1.Repository.DbContext;
using Microsoft.EntityFrameworkCore;

namespace grow_api_v1.Repository;

public class UserRepository : BaseRepository<User, Guid>, IUserRepository
{
    private readonly DbSet<User> _db;

    public UserRepository(GrowDbContext dbContext) : base(dbContext)
    {
        _db = dbContext.Users;
    }
    
    public async Task<User> GetAsync(Guid id)
    {
        return await _db
            .Where(u =>
                u.DeletedAt == null &&
                u.Id == id)
            .FirstOrDefaultAsync();
    }
}