using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using grow_api_v1.DTOs.Responses;
using grow_api_v1.DTOs.System;
using grow_api_v1.Extensions;
using grow_api_v1.Models;
using grow_api_v1.Services;
using grow_api_v1.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace grow_api_v1.Controllers
{
    [ApiController]
    [EnableCors("AllowCorsPolicy")]
    [Route("produce")]
    public class GrowProduceController : ControllerBase
    {
        private readonly IProduceService _produceService;

        /// <summary>
        ///     Initializes a new instance of the <see cref="GrowProduceController" /> class.
        /// </summary>
        public GrowProduceController(IProduceService produceService)
        {
            _produceService = produceService;
        }

        /// <summary>
        /// Gets all produce by season.
        /// </summary>
        /// <response code="200">Returns all produce filtered by season.</response>
        [HttpGet("season/{id}")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(ApiResponse<List<ProduceVM>>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBySeason([FromRoute] string id)
        {
            var user = User.GetUserId();
            
            return StatusCode(StatusCodes.Status200OK, new ApiResponse<List<ProduceVM>>(
                await _produceService.GetBySeason(user, id ), true, HttpStatusCode.OK));
        }
    }
}