using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkillzMatrixAPI.Data.Repositorys.Interfaces;

namespace SkillzMatrixAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillzController : ControllerBase
    {
        private ISkillzRepository _ISkillzRepository;
        public SkillzController(ISkillzRepository skillzRepository)
        {
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
    }
}