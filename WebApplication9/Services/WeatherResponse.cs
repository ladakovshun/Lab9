public class WeatherResponse
{
    public Main Main { get; set; }
    public Weather[] Weather { get; set; }
    public string Name { get; set; } // Назва міста

    public double Temperature => Main?.Temp ?? 0;
    public string Description => Weather != null && Weather.Length > 0 ? Weather[0].Description : string.Empty;
}

public class Main
{
    public double Temp { get; set; }
}

public class Weather
{
    public string Description { get; set; }
}
