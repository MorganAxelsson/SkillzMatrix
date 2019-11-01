using Newtonsoft.Json;
using SkillzMatrix.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SkillzMatrix.Services
{
    public class UserService
    {
        public async Task<UserModel[]> GetAllUsersAsync()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync("https://localhost:44344/api/users/getall");
            return JsonConvert.DeserializeObject<UserModel[]>(result);
        }
    }
}
