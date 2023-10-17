using System.Net.Http.Json;
using TestNew.Client.Entities;

namespace TestNew.Client.ApiServices;


public class ApiTest : IApiTest
{
     private readonly HttpClient _client;

    public ApiTest(HttpClient client)
    => _client = client;
    

    public async Task<WeatherForecast[]?> GetWeatherForecastAsync()
    {
       return await _client.GetFromJsonAsync<WeatherForecast[]>("api/v1/data"); 
    }
}