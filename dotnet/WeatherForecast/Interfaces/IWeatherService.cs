namespace WeatherForecast.Interfaces;

public interface IWeatherService
{
    public Task<IEnumerable<WeatherForecast>> GetForecast();
}
