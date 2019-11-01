using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SkillzMatrixAPI.Data.Entities;
using SkillzMatrixAPI.Data.Repositorys.Interfaces;

namespace SkillzMatrixAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ILogger<TeamsController> _logger;
        private ITeamsRepository _TeamsRepository;
        public TeamsController(ILogger<TeamsController> logger, ITeamsRepository teamsRepository)
        {
            _logger = logger;
            _TeamsRepository = teamsRepository;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var teams =  await _TeamsRepository.GetAll();

            if (teams != null)
                return Ok(teams);

            return NotFound();
        }
    }
}