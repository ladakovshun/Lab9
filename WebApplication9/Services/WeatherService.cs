using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WebApplication9.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherResponse> GetWeatherAsync(string location)
        {
            var apiKey = "dc7817ffdcb43207f35bfdc10ccca76f"; //API ключ
            var response = await _httpClient.GetFromJsonAsync<WeatherResponse>(
                $"https://api.openweathermap.org/data/2.5/weather?q={location}&appid={apiKey}&units=metric");

            return response;
        }
    }
}


