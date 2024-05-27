using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using grow_api_v1.Models;

namespace grow_api_v1.Repository
{
    public interface IGrowRepository
    {
        public Task<List<Stock>> GetAllStockBySeason(string seasonName);
        public Task<Order> Get(Guid Id);
    }
}