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
    public class TeamService : ITeamService
    {
        private readonly HttpClient _client;
        private IConfiguration _config;      
        public TeamService(IConfiguration config, HttpClient client)
        {
            _client = client;
            _config = config;      
        }
        public async Task<TeamModel[]> GetAllTeamsAsync()
        {
            var result = await _client.GetStringAsync($"api/teams/getall");
            return JsonConvert.DeserializeObject<TeamModel[]>(result);
        }
    }
}
