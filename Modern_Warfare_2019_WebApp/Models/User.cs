using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modern_Warfare_2019_WebApp.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public User(string name,string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public User()
        {

        }
    }
}
