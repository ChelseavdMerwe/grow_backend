using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using grow_api_v1.Constants.Errors;
using grow_api_v1.DTOs.Responses;
using grow_api_v1.Exceptions;
using grow_api_v1.Repository;
using grow_api_v1.Repository.Interfaces;
using grow_api_v1.Services.Interfaces;
using Microsoft.OpenApi.Extensions;

namespace grow_api_v1.Services;

public class ProduceService : IProduceService
{
    private readonly IUserRepository _userRepository;
    private readonly IProduceRepository _produceRepository;

    public ProduceService(
        IUserRepository userRepository,
        IProduceRepository produceRepository
    )
    {
        _userRepository = userRepository;
        _produceRepository = produceRepository;
    }
    public async Task<List<ProduceVM>> GetBySeason(Guid userId, string seasonId)
    {
        var user = await _userRepository.GetAsync(userId)
                   ?? throw new NotFoundException(RepositoryErrors.User_DoesNotExist);

        var produceList = await _produceRepository.GetAllBySeason(seasonId);

        var produceListVM = new List<ProduceVM>();

        foreach (var produce in produceList)
        {
            if (produce != null)
                produceListVM.Add(new()
                {
                    Category = produce.Category.GetDisplayName(),
                    Id = produce.Id,
                    Season = produce.Season.GetDisplayName()
                });
        };
        
        return produceListVM;

    }
}