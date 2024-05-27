using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using grow_api_v1.Models;
using grow_api_v1.Models.Database;
using grow_api_v1.Repository.DbContext;
using grow_api_v1.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;

namespace grow_api_v1.Repository;

public class ProduceRepository : BaseRepository<Produce, Guid>, IProduceRepository
{
    private readonly DbSet<Produce> _db;

    public ProduceRepository(GrowDbContext dbContext) : base(dbContext)
    {
        _db = dbContext.Produce;
    }
    
    
    public async Task<List<Produce>> GetAllBySeason(string season)
    {
        return await _db
            .Where(p => p.Season.GetDisplayName() == season 
                        && p.DeletedAt != null).ToListAsync();
    }

    public async Task<Produce?> GetBySeason(string season)
    {
        return await _db
            .Where(p => p.Season.GetDisplayName() == season 
                        && p.DeletedAt != null).FirstOrDefaultAsync();
    }

    public Task<Produce> Get(int Id)
    {
        throw new NotImplementedException();
    }
}