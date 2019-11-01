using Newtonsoft.Json;
using SkillzMatrix.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    }
}
