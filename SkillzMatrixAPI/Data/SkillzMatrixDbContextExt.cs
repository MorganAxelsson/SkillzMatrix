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
            #region teams
            if (!context.Teams.Any())
            {
                var teams = new List<Teams>()
                {
                    new Teams
                    {
                        TeamName = "A-Team"
                    },
                    new Teams
                    {
                        TeamName = "B-Team"
                    },
                    new Teams
                    {
                        TeamName = "Team Mint"
                    }

                };
                context.Teams.AddRange(teams);
            }

            #endregion

            #region Skillz
            if (!context.Skillz.Any())
            {
                var competence = new List<Skillz>()
                {
                    new Skillz
                    {
                        Name = "c#",
                        Description = "programmeringsspråk"
                    },
                    new Skillz
                    {
                        Name = "Visual studio",
                        Description = "Verktyg"
                    },
                    new Skillz
                    {
                        Name = "Java",
                        Description = "programmeringsspråk"
                    },
                    new Skillz
                    {
                        Name = "F#",
                        Description = "programmeringsspråk"
                    },
                };
                context.Skillz.AddRange(competence);
            }
            #endregion
            context.SaveChanges();
            #region userInTeams
            if (!context.UserInTeams.Any())
            {
                var userInTeams = new List<UserInTeams>()
                {
                    new UserInTeams
                    {
                        TeamId = 1,
                        UserId = 1
                    },
                    new UserInTeams
                    {
                        TeamId = 1,
                        UserId = 2
                    },
                    new UserInTeams
                    {
                        TeamId = 2,
                        UserId = 3
                    },
                    new UserInTeams
                    {
                        TeamId = 3,
                        UserId = 4
                    },
                    new UserInTeams
                    {
                        TeamId = 3,
                        UserId = 1
                    }

                };
                context.UserInTeams.AddRange(userInTeams);
            }
            #endregion
            #region UserSkillz

            if (!context.UserSkillz.Any())
            {
                var userComp = new List<UserSkillz>()
                {
                    new UserSkillz
                    {
                        SkillzId = 1,
                        LevelsId = 2,
                        UserId = 1
                    },
                    new UserSkillz
                    {
                        SkillzId = 2,
                        LevelsId = 4,
                        UserId = 1
                    },
                    new UserSkillz
                    {
                        SkillzId = 3,
                        LevelsId = 1,
                        UserId = 2
                    },
                    new UserSkillz
                    {
                        SkillzId = 3,
                        LevelsId = 1,
                        UserId = 3
                    },
                    new UserSkillz
                    {
                        SkillzId = 4,
                        LevelsId = 3,
                        UserId = 4
                    }
                };
                context.UserSkillz.AddRange(userComp);

            }
            #endregion
            context.SaveChanges();
        }
    }
}
