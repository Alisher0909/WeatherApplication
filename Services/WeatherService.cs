using WeatherApp.Interfaces;
using WeatherApp.Models;
using System.Text.Json;

namespace WeatherApp.Services;

public class WeatherService(HttpClient httpClient) : IWeatherService
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly string apiKey = "a4f47604f64115571e6884eeb33456c8";

    public async Task<WeatherResponse> GetWeatherAsync(string city)
    {
        var responce = await _httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}");

        if (!responce.IsSuccessStatusCode)
        {
            throw new Exception($"Failed to retrive data for city: {city}");
        }

        var json = await responce.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

        var weather = JsonSerializer.Deserialize<WeatherResponse>(json, options);

        return weather!;
    }
}