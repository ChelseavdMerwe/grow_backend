using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using grow_api_v1.Models.Database;

namespace grow_api_v1.Repository.Interfaces;

public interface IProduceRepository : IBaseRepository<Produce, int>
{
    Task<Produce?> GetBySeason(string seasonId);
    
    Task<List<Produce?>> GetAllBySeason(string seasonId);
}