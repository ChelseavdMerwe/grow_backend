using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using grow_api_v1.Models;
using grow_api_v1.Repository;
using grow_api_v1.Services.Interfaces;

namespace grow_api_v1.Services
{
    public class GrowService : IGrowService
    {
        private readonly IGrowRepository _growRepository;

        public GrowService(IGrowRepository growRepository)
        {
            _growRepository = growRepository;
        }
        public Task<List<Stock>> GetAllStockBySeason(string seasonName)
        {
            var all_stock = _growRepository.GetAllStockBySeason(seasonName);
            return all_stock;
        }

        public Task<Order> GetOrder(Guid id)
        {
            var order = _growRepository.Get(id);
            if (order == null)
            {
                throw new KeyNotFoundException("No restaurant found with the id: "+ id);
            }
            return order;
        }
    }
}