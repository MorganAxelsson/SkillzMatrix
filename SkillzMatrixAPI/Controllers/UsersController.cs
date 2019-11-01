using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SkillzMatrixAPI.Data.Repositorys.Interfaces;

namespace SkillzMatrixAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<TeamsController> _logger;
        private IUserRepository _UserRepository;
        public UsersController(ILogger<TeamsController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _UserRepository = userRepository;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _UserRepository.GetAll();

            if (users != null)
                return Ok(users);

            return NotFound();
        }
    }
}