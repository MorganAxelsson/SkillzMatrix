using Microsoft.Extensions.Configuration;
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
    public class SkillzService : ISkillzService
    {
        private readonly HttpClient _client;
        private IConfiguration _config;        
        public SkillzService(IConfiguration config, HttpClient client)
        {
            _client = client;
            _config = config;            
        }
        public async Task<List<SkillzModel>> GetAllSkillzAsync()
        {
            var result = await _client.GetStringAsync($"api/skillz/getall");
            return JsonConvert.DeserializeObject<List<SkillzModel>>(result);
        }
        public async Task<SkillzModel> AddSkillAsync(SkillzModel skillzModel)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(skillzModel), Encoding.UTF8, "application/json");
            var result = await _client.PostAsync($"api/skillz/add", content);

            if (result.IsSuccessStatusCode)
            {
                return await System.Text.Json.JsonSerializer.DeserializeAsync<SkillzModel>(await result.Content.ReadAsStreamAsync());
            }

            return null;
        }
        public async void DeleteSkillAsync(int id)
        {
            var result = await _client.DeleteAsync($"api/skillz/" + id);

           
        }
    }
}
