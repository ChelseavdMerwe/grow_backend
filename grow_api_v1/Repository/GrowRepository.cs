using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using grow_api_v1.Controllers;
using grow_api_v1.Models;
using grow_api_v1.Repository.DbContext;
using Microsoft.EntityFrameworkCore;

namespace grow_api_v1.Repository
{
    public class GrowRepository : IGrowRepository
    {
        /// <summary>
        ///     A <see cref="RestaurantDBContext"/> representing the database context.
        /// </summary>
        private readonly GrowDbContext _context;

        /// <summary>
        ///     Initializes a new instance of the <see cref="RestaurantStore"/> class.
        /// </summary>
        /// <param name="restaurantDbContext">
        ///     A <see cref="RestaurantDBContext"/> representing the restaurant database context.
        /// </param>
        public GrowRepository(GrowDbContext growDbContext)
        {
            _context = growDbContext;
        }

        public Task<List<Stock>> GetAllStockBySeason(string seasonName)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> Get(Guid Id)
        {
            return await _context.Orders.Include(p => p.Stock)
                .FirstOrDefaultAsync(p => p.Id ==Id) ?? throw new InvalidOperationException();
        }
        
    }
}