using RestApi.Models.v2;

namespace RestApi.Services.v2
{
    public static class ModelFactory
    {
        public static WeatherForecast CreateWeatherForecast()
        {
            return new WeatherForecast
            {
                Date= DateTime.Now,
                TemperatureC = 32,
                Summary = "created by v2",
                Version = "v2"
            };
        }
    }
}
