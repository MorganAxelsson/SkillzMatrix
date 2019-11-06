using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillzMatrixAPI.Data.Repositorys.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(Guid id);
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
        void Add(TEntity entity);
        
    }
}
