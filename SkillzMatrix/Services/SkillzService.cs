using Newtonsoft.Json;
using SkillzMatrix.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SkillzMatrix.Services
{
    public class SkillzService
    {
        public async Task<SkillzModel[]> GetAllTeamsAsync()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync("https://localhost:44344/api/skillz/getall");
            return JsonConvert.DeserializeObject<SkillzModel[]>(result);
        }
        public async void AddSkillAsync(SkillzModel skillzModel)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(skillzModel), Encoding.UTF8, "application/json");
            var result = await client.PostAsync("https://localhost:44344/api/skillz/add", content);
           // return JsonConvert.DeserializeObject<SkillzModel[]>(result);
        }
        public async void DeleteSkillAsync(int id)
        {
            HttpClient client = new HttpClient();
            //var result = await client.PostAsync("https://localhost:44344/api/skillz/getall");
            // return JsonConvert.DeserializeObject<SkillzModel[]>(result);
        }
    }
}
