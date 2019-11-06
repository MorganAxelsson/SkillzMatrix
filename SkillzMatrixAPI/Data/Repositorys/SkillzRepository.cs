using SkillzMatrixAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkillzMatrixAPI.Data.Repositorys.Interfaces;

namespace SkillzMatrixAPI.Data.Repositorys
{
    public class SkillzRepository : Repository<Skillz>, ISkillzRepository
    {
        private readonly SkillzMatrixDbContext _context;
        public SkillzRepository(SkillzMatrixDbContext context) : base(context)
        {
            _context = context;
        }
      
    }
}
