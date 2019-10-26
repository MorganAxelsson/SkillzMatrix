using SkillzMatrixAPI.Data.Entities;
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
            #region Users
            if (!context.Users.Any())
            {
                var user = new List<Users>()
                {
                    new Users
                    {
                       Name = "Morgan Axelsson",
                       FirstName ="Morgan",
                       LastName ="Axelsson"
                    },
                    new Users
                    {
                      Name = "Johan Karlsson",
                      FirstName = "Johan",
                      LastName = "Karlsson"
                    },
                    new Users
                    {
                        Name = "Martin Persson",
                        FirstName = "Martin",
                        LastName = "Persson"
                    },
                    new Users
                    {
                        Name = "Klas Bertilsson",
                        FirstName = "Klas",
                        LastName = "Bertilsson  "
                    }
                };
                context.AddRange(user);
            }
            #endregion
            #region Levels
            if (!context.Levels.Any())
            {
                var Levelss = new List<Levels>()
                {
                   new Levels
                   {                    
                       LevelNumber = 0,
                       Description = "När du hört talas om det men aldrig testat eller använt det.",
                       ShortDescription="Hört talas om men inte använt"
                   },
                   new Levels
                   {                       
                       LevelNumber = 1,
                       Description = "När du testat det men aldrig jobbat med det.",
                       ShortDescription="Testat det men inte jobbat med det."
                   },
                   new Levels
                   {                      
                       LevelNumber = 2,
                       Description = "använt det några gånger i arbetet.",
                       ShortDescription="Använt det några gånger i arbetet"
                   },
                   new Levels
                   {                      
                       LevelNumber = 3,
                       Description = "När du jobbat med det flertalet gånger.",
                       ShortDescription="jobbat med det ofta"
                   }
                   ,
                   new Levels
                   {                     
                       LevelNumber = 4,
                       Description = "Du kan hålla utbildning för andra om det.",
                       ShortDescription="Expert"
                   }
                };

                context.Levels.AddRange(Levelss);
            }

            #endregion
            #region Teams
            context.Teams.Add(new Entities.Teams {
                Description="",
                TeamName="TestTeam"                
            });

            #endregion

            context.SaveChanges();
        }
    }
}
