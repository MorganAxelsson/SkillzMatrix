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
    public class SkillzService
    {
        private HttpClient _client;
        private IConfiguration _config;
        private string baseApiUrl;
        public SkillzService(IConfiguration config)
        {
            _client = new HttpClient();
            _config = config;
            baseApiUrl = _config["BaseApiUrl"];
        }
        public async Task<List<SkillzModel>> GetAllSkillzAsync()
        {            
            var result = await _client.GetStringAsync(baseApiUrl + "api/skillz/getall");
            return JsonConvert.DeserializeObject<List<SkillzModel>>(result);
        }
        public async void AddSkillAsync(SkillzModel skillzModel)
        {            
            StringContent content = new StringContent(JsonConvert.SerializeObject(skillzModel), Encoding.UTF8, "application/json");
            var result = await _client.PostAsync(baseApiUrl + "api/skillz/add", content);           
        }
        public async void DeleteSkillAsync(int id)
        {
          var result = await _client.DeleteAsync(baseApiUrl + "api/skillz/" + id);          
        }
    }
}
