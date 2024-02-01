using WorkintechRestApiDemo.Domain;
using WorkintechRestApiDemo.Domain.ApiLayer;

namespace WorkintechRestApiDemo.Business
{
    public interface ICurrencyService : IBaseSingletonService
    {
        Task<string> GetCurrencySymbol(string currencyCode);

        Task<CurrencyResponse> GetCurrency();

        Task<ApiLayerResponse> PostCurrencyToApiLayer(string startDate, string endDate);
    }
}

//=> Bütün bu yaptığımız işlemler dependency injection. 