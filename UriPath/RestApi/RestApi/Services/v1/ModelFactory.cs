using RestApi.Models.v1;

namespace RestApi.Services.v1
{
    public static class ModelFactory
    {
        public static WeatherForecast CreateWeatherForecast()
        {
            return new WeatherForecast
            {
                Date= DateTime.Now,
                TemperatureC = 32,
                Summary = "created by v1"
            };
        }
    }
}
