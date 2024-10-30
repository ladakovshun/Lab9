namespace WebApplication9.Models
{
    public class WeatherInfo
    {
        public MainInfo Main { get; set; }
        public string Name { get; set; }
    }

    public class MainInfo
    {
        public float Temp { get; set; }
        public float Humidity { get; set; }
    }

}
