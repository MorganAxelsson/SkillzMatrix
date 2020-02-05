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
    public class UserService : IUserService
    {
        private readonly HttpClient _client;
        private IConfiguration _config;
 
        public UserService(IConfiguration config, HttpClient client)
        {
            _client = client;
            _config = config;
           
        }
        public async Task<UserModel[]> GetAllUsersAsync()
        {
            var result = await _client.GetStringAsync($"api/users/getall");
            return JsonConvert.DeserializeObject<UserModel[]>(result);
        }
    }
}
