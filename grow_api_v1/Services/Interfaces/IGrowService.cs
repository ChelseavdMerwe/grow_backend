using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using grow_api_v1.Models;

namespace grow_api_v1.Services.Interfaces
{
    public interface IGrowService
    {
        public Task<List<Stock>> GetAllStockBySeason(string seasonName);
        public Task<Order> GetOrder(Guid id);
    }
}