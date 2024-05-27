using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using grow_api_v1.DTOs.Responses;

namespace grow_api_v1.Services.Interfaces;

public interface IProduceService
{
    Task<List<ProduceVM>> GetBySeason(Guid user, string seasonId);
}