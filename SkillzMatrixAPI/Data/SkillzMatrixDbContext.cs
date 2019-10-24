using Microsoft.EntityFrameworkCore;
using SkillzMatrixAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillzMatrixAPI.Data
{
    public class SkillzMatrixDbContext : DbContext
    {
        public DbSet<Skillz> Skillz {get;set;}
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Levels> Levels { get; set; }
        public DbSet<UserSkillz> UserSkillz { get; set; }
        public DbSet<UserInTeams> UserInTeams { get; set; }

        public SkillzMatrixDbContext(DbContextOptions<SkillzMatrixDbContext> options) :base(options)
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);                   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserInTeams>().HasKey(sc => new { sc.UserId, sc.TeamId });
        }
    }
}
