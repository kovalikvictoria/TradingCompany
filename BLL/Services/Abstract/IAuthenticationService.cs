using DTO;
using System.Threading.Tasks;

namespace BLL.Services.Abstract
{
    public interface IAuthenticationService
    {
        Task<bool> CheckCredentials(CredentialsDTO credentials);
        Task<bool> UserExist(string login);
    }
}
