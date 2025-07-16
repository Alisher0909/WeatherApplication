using WeatherApp.Models;

namespace WeatherApp.Interfaces;

public interface IWeatherService
{
    Task<WeatherResponse> GetWeatherAsync(string city);
}