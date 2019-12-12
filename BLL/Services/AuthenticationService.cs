using DAL.Concrete;
using DTO;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthenticationService
    {
        private readonly UserDal _userDal;
        public AuthenticationService(UserDal userDal)
        {
            _userDal = userDal;
        }
        public bool CheckCredentials(CredentialsDTO credentials)
        {
            User user = _userDal.GetByLogin(credentials.Login);
            if (user.HashPassword == HashPassword.Hash(credentials.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UserExist(string login)
        {
            if (_userDal.GetByLogin(login) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

