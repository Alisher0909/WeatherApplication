namespace WeatherApp.Models;

public class WeatherResponse
{
    public MainInfo? Main { get; set; }
    public List<WeatherInfo>? Weather { get; set; }
    public SysInfo? Sys { get; set; }
    public WindInfo? Wind { get; set; }
    public int? Visibility { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Temperature in {Name}: {Main!.Temp - 273} C°,\nCountry: {Sys!.Country}, \nSunrise: {Sys.Sunrise}, \nSunset: {Sys.Sunset}, \nWind: {Wind!.Speed} m/s,\nDeg: {Wind.Deg}, \nVisibility: {Visibility} km ";
    }
}
