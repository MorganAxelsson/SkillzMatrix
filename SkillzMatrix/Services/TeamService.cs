using Newtonsoft.Json;
using Shared.Models;
using SkillzMatrix.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SkillzMatrix.Services
{
    public class TeamService
    {
        public async Task<TeamModel[]> GetAllTeamsAsync()
        {                    
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync("https://localhost:44344/teams/getall");
            return JsonConvert.DeserializeObject<TeamModel[]>(result);
        }
    }
}
