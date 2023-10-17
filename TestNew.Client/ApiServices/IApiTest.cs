using TestNew.Client.Entities;

namespace TestNew.Client.ApiServices;




public interface IApiTest
{
    public Task<WeatherForecast[]?> GetWeatherForecastAsync();
}