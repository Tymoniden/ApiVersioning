using Microsoft.AspNetCore.Mvc;
using RestApi.Models.v1;
using RestApi.Services.v1;

namespace RestApi.Controllers.v1
{
    [ApiController]
    //[Route("api/1/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeather")]
        [Route("api/1/WeatherForecast")]
        public WeatherForecast GetWeather()
        {
            return ModelFactory.CreateWeatherForecast();
        }
    }
}