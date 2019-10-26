using Microsoft.EntityFrameworkCore;
using SkillzMatrixAPI.Data.Repositorys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillzMatrixAPI.Data.Repositorys
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private SkillzMatrixDbContext _context;
        public Repository(SkillzMatrixDbContext context)
        {
            _context = context;
        }
        public async Task<TEntity> Get(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async void Add(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
