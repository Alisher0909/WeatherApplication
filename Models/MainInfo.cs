using System.Text.Json.Serialization;

namespace WeatherApp.Models;

public class MainInfo
{
    public double Temp { get; set; }

    [JsonPropertyName("feels_like")]
    public double FeelsLike { get; set; }
    public int Humidity { get; set; }
}
