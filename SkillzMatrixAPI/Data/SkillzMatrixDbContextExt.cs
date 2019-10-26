using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillzMatrixAPI.Data
{
    public static class SkillzMatrixDbContextExt
    {
        /// <summary>
        /// adding testdata
        /// </summary>
        /// <param name="context"></param>
        public static void SeedData(this SkillzMatrixDbContext context)
        {
            context.Teams.Add(new Entities.Teams {
                Description="",
                TeamName="TestTeam"                
            });

            context.SaveChanges();
        }
    }
}
