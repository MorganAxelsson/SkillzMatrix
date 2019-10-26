using Newtonsoft.Json;
using SkillzMatrix.Shared;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SkillzMatrix.Services
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            string baseUrl = "https://localhost:44344/";
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync("https://localhost:44344/weatherforecast");
            return JsonConvert.DeserializeObject<WeatherForecast[]>(result);
        }
    }
}
