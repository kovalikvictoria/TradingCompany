﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public enum EUser
    {
        ID = 0,
        NAME,
        LOGIN,
        PASSWORD,
        AGE
    }

    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string HashPassword { get; set; }
        public int Age { get; set; }

        public User(string name = "", string login = "",
            string password = "", int age = 0)
        {
            Name = name;
            Login = login;
            HashPassword = password;
            Age = age;
        }
    }
}
