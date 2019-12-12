using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class UserDal : ADalCrud<User> // ADalRead<User>
    {
        public UserDal() : base()
        {
        }

        // class ADalRead
        protected override string GetTableName()
        {
            return "[USER]";
        }

        protected override User CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList<string>();
            User user = new User(parameters[Convert.ToInt32(EUser.NAME)],
                parameters[Convert.ToInt32(EUser.LOGIN)],
                parameters[Convert.ToInt32(EUser.PASSWORD)],
                Convert.ToInt32(parameters[Convert.ToInt32(EUser.AGE)]));
            user.Id = Convert.ToInt32(parameters[Convert.ToInt32(EUser.ID)]);
            return user;
        }

        // class ADalCrud
        protected override IDictionary<string, string> GetValues(User user)
        {
            // TODO Use Enum
            IDictionary<string, string> result = new Dictionary<string, string>();
            result.Add(EUser.ID.ToString().ToLower(), user.Id.ToString());
            result.Add(EUser.NAME.ToString().ToLower(), user.Name);
            result.Add(EUser.LOGIN.ToString().ToLower(), user.Login);
            result.Add(EUser.PASSWORD.ToString().ToLower(), user.HashPassword);
            result.Add(EUser.AGE.ToString().ToLower(), user.Age.ToString());

            return result;
        }

        public void PrintUser(User user)
        {
            Console.WriteLine(
                   "\nID: " + user.Id.ToString() +
                   "\nNAME: " + user.Name +
                   "\nLOGIN: " + user.Login +
                   "\nPASSWORD: " + user.HashPassword +
                   "\nAGE: " + user.Age.ToString() + "\n");
        }

        public void PrintListOfUsers(IList<User> users)
        {
            foreach (User user in users)
            {
                PrintUser(user);
            }
        }

        //public bool Login(string username, string password)
        //{
        //    string hashedPassword = hash(password);

        //    using (User user = new User())
        //    {
        //        return user.Any(user => user.Login && )
        //    }
        //}

    }
}
