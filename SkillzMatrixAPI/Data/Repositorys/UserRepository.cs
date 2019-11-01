using SkillzMatrixAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkillzMatrixAPI.Data.Repositorys.Interfaces;

namespace SkillzMatrixAPI.Data.Repositorys
{
    public class UserRepository : Repository<Users>, IUserRepository
    {
        private SkillzMatrixDbContext _context;
        public UserRepository(SkillzMatrixDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
