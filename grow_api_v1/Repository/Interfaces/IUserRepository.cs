using System;
using System.Threading.Tasks;
using grow_api_v1.Models;

namespace grow_api_v1.Repository;

public interface IUserRepository
{
    Task<User> GetAsync(Guid id);
}