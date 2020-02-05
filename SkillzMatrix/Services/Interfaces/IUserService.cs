using SkillzMatrix.Shared.Models;
using System.Threading.Tasks;

namespace SkillzMatrix.Services
{
    public interface IUserService
    {
        Task<UserModel[]> GetAllUsersAsync();
    }
}