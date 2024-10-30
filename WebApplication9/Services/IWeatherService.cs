using System.Threading.Tasks;

namespace WebApplication9.Services
{
    public interface IWeatherService
    {
        Task<WeatherResponse> GetWeatherAsync(string city); 
    }
}
