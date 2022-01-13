using WebWeatherApp.OpenWeatherMap;

namespace WebWeatherApp.Repositories
{
    public interface IWeatherForecastRepository
    {
        WeatherResponse GetForecast(string city);
    }
}
