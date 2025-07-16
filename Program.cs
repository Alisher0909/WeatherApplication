using WeatherApp.Services;

var httpClient = new HttpClient();

var weatherService = new WeatherService(httpClient);

Console.Write("Enter city name: ");

var weather = await weatherService.GetWeatherAsync(Console.ReadLine()!);

Console.WriteLine(weather); 

