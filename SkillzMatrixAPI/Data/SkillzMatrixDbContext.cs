using Microsoft.EntityFrameworkCore;
using SkillzMatrixAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillzMatrixAPI.Data
{
    public class SkillzMatrixDbContext : DbContext
    {
        public DbSet<Skillz> Skillz {get;set;}


        public SkillzMatrixDbContext(DbContextOptions<SkillzMatrixDbContext> options) :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Server=.;Database=entityframework;Trusted_Connection=true;MultipleActiveResultSets=true;");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
