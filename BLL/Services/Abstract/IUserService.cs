using DTO;
using System.Threading.Tasks;

namespace BLL.Services.Abstract
{
    public interface IUserService
    {
        Task<UserDTO> GetUserById(int userId);

        Task<UserDTO> GetUserByLogin(string userLogin);

        Task<UserDTO> AddUser(UserDTO user);

        Task<UserDTO> UpdateUser(UserDTO user);

        Task RemoveUser();
    }
}