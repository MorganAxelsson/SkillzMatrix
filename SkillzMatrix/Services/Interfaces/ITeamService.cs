using SkillzMatrix.Shared.Models;
using System.Threading.Tasks;

namespace SkillzMatrix.Services
{
    public interface ITeamService
    {
        Task<TeamModel[]> GetAllTeamsAsync();
    }
}