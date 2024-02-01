namespace WorkintechRestApiDemo.Business.City
{
    public interface ICityService :IBaseService
    {
        List<string> GetCities();
    }
}