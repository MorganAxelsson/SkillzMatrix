using SkillzMatrix.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkillzMatrix.Services
{
    public interface ISkillzService
    {
        Task<SkillzModel> AddSkillAsync(SkillzModel skillzModel);
        void DeleteSkillAsync(int id);
        Task<List<SkillzModel>> GetAllSkillzAsync();
    }
}