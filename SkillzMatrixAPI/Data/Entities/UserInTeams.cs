using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillzMatrixAPI.Data.Entities
{
    public class UserInTeams
    {
        public Users User { get; set; }
        public int UserId { get; set; }
        public Teams Team { get; set; }
        public int TeamId { get; set; }
    }
}
