using Newtonsoft.Json;
using SkillzMatrix.Shared;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SkillzMatrix.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        //{
        //    var rng = new Random();
        //    return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = startDate.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    }).ToArray());
        //}

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            string baseUrl = "https://localhost:44344/";
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync("https://localhost:44344/weatherforecast");
            return JsonConvert.DeserializeObject<WeatherForecast[]>(result);
        }
    }
}
