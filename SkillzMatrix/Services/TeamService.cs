using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SkillzMatrix.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SkillzMatrix.Services
{
    public class TeamService
    {
        private HttpClient _client;
        private IConfiguration _config;
        private string baseApiUrl;
        public TeamService(IConfiguration config)
        {
            _client = new HttpClient();
            _config = config;
            baseApiUrl = _config["BaseApiUrl"];
        }
        public async Task<TeamModel[]> GetAllTeamsAsync()
        {                   
            var result = await _client.GetStringAsync(baseApiUrl + "api/teams/getall");
            return JsonConvert.DeserializeObject<TeamModel[]>(result);
        }
    }
}
