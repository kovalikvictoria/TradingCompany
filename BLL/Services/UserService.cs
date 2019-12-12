using AutoMapper;
using DAL.Concrete;
using DTO;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        private readonly UserDal _userDal;
        private readonly IMapper _mapper;

        public UserService(UserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }
        public IEnumerable<User> GetViewModels()
        {
            IEnumerable<UserDTO> usersDTO = this.GetAll();
            var usersView = usersDTO.ToList().ConvertAll(x => _mapper.Map<UserDTO, User>(x));
            return usersView;
        }
        public IEnumerable<UserDTO> GetAll()
        {
            List<UserDTO> usersDTO = new List<UserDTO>();
            foreach (var user in _userDal.GetAll())
            {
                UserDTO userDTO = _mapper.Map<User, UserDTO>(user);
                usersDTO.Add(userDTO);
            }
            return usersDTO;
        }
        public UserDTO GetById(int id)
        {
            User user = _userDal.GetById(id);
            UserDTO userDTO = _mapper.Map<User, UserDTO>(user);
            return userDTO;
        }
        public UserDTO GetByLogin(string login)
        {
            User user = _userDal.GetByLogin(login);
            UserDTO userDTO = _mapper.Map<User, UserDTO>(user);
            return userDTO;
        }
        public bool CreateUser(User user)
        {
            try
            {
                _userDal.Insert(user);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool UpdateUser(User user)
        {
            try
            {
                _userDal.UpdateByEntity(user);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public string GetHashedPassword(string password)
        {
            return HashPassword.Hash(password);
        }

        public bool IsLoginExists(string login)
        {
            if (_userDal.GetByLogin(login) != null)
            {
                return false;
            }
            return true;
        }
    }
}
