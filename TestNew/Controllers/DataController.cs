using Microsoft.AspNetCore.Mvc;
using TestNew.Client.Entities;

namespace TestNew.Controllers;



[ApiController]
[Route("api/v1/data")]
public class DataController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
           await Task.Delay(500);

        var startDate = DateOnly.FromDateTime(DateTime.Now);
        var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        WeatherForecast[]?  forecasts = Enumerable.Range(1, 50).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        }).ToArray();


        return Ok(forecasts);
    }


}