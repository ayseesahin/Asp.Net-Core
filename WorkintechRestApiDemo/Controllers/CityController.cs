using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using WorkintechRestApiDemo.Business.City;

namespace WorkintechRestApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class CityController : ControllerBase
	{
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

    
        [HttpGet]
        public IActionResult GetAll()
        {
            var cities = _cityService.GetCities();
            Log.Logger.Information("Cities are fetched. @{cities}", cities);
            return Ok(cities);
        }
    }
}

