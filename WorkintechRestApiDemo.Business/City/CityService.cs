using System;
namespace WorkintechRestApiDemo.Business.City
{
    public class CityService : BaseService, ICityService
    {
        public List<string> GetCities()
        {
            var cities = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "İzmir",
                "Adana",
                "Afyonkarahisar",
                "Adıyaman",
                "Ağrı"
            };

            return cities;
        }
    }
}

