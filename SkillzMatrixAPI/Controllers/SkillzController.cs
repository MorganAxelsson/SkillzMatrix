using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SkillzMatrix.Shared.Models;
using SkillzMatrixAPI.Data.Entities;
using SkillzMatrixAPI.Data.Repositorys.Interfaces;

namespace SkillzMatrixAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillzController : ControllerBase
    {
        private readonly ILogger<SkillzController> _logger;
        private ISkillzRepository _ISkillzRepository;
        public SkillzController(ILogger<SkillzController> logger, ISkillzRepository skillzRepository)
        {
            _logger = logger;
            _ISkillzRepository = skillzRepository;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var skillz = await _ISkillzRepository.GetAll();

            if (skillz != null)
                return Ok(skillz);

            return NotFound();
        }
        [HttpPost("Add")]
        public async void Post([FromBody] SkillzModel value)
        {
            if(value != null)
            {
                var skillzEntity = new Skillz();
                skillzEntity.Description = value.Description;
                skillzEntity.Name = value.Name;

                 _ISkillzRepository.Add(skillzEntity);
                
            }
           

        }
    }
}