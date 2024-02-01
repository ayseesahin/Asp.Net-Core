using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using WorkintechRestApiDemo.Business;
using WorkintechRestApiDemo.Domain.ApiLayer;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkintechRestApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class CurrencyController : Controller
    {
        private readonly Business.ICurrencyService _currencyService;

        public CurrencyController(Business.ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        } //Interface'i inşılayz ediyoruz.

        [HttpGet("{currencyCode}")]

        public async Task<ActionResult<string>> GetCurrencySymbol(string currencyCode)
        {
            Log.Information("GetCurrencySymbol methodu çağrıldı");

            if (string.IsNullOrEmpty(currencyCode))
            {
                Log.Error("currencyCode boş geçilemez");
                throw new NullReferenceException();
            }

            try
            {
                string currencySymbol = await _currencyService.GetCurrencySymbol(currencyCode);
                Log.Information("currencySymbol: {currencySymbol}", currencySymbol);
                return currencySymbol;
            }
            catch (System.Exception e)
            {
                Log.Error(e.Message, e);
                return BadRequest("Hata oluştu" + e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<Domain.CurrencyResponse>> GetCurrency()
        {
            Log.Information("GetCurrency methodu çağrıldı");

            try
            {
                Domain.CurrencyResponse currencyResponse = await _currencyService.GetCurrency();
                Log.Logger.Information("currencyResponse: {@currencyResponse}", currencyResponse);
                return currencyResponse;
            }
            catch(System.Exception e)
            {
                Log.Error(e.Message, e);
                throw e;
            }
        }

        [HttpPost]
        public async Task<ActionResult<ApiLayerResponse>> PostCurrencyToApiLayer(string startDate, string endDate)
        {
            Log.Logger.Information("PostCurrencyToApiLayer methodu çağrıldı");

                 ApiLayerResponse apiLayerResponse = await _currencyService.PostCurrencyToApiLayer(startDate, endDate);

                 Log.Logger.Information("apiLayerResponse: {@apiLayerResponse}", apiLayerResponse);

            return apiLayerResponse;


        }
    }
}

