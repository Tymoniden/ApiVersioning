using Microsoft.AspNetCore.Mvc;
using RestApi.Models.v2;
using RestApi.Services.v2;

namespace RestApi.Controllers.v2
{
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeather")]
        [Route("api/2/WeatherForecast")]
        public WeatherForecast GetWeather()
        {
            return ModelFactory.CreateWeatherForecast();
        }
    }
}