using SkillzMatrixAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkillzMatrixAPI.Data.Repositorys.Interfaces;

namespace SkillzMatrixAPI.Data.Repositorys
{
    public class TeamsRepository : Repository<Teams>, ITeamsRepository
    {
        private SkillzMatrixDbContext _context;
        public TeamsRepository(SkillzMatrixDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
