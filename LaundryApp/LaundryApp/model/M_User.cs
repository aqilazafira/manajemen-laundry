using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryApp.model
{
    internal class M_User
    {
        string username, email, password;
    
    public M_User()
        {

        }

        public M_User(string username, string email, string password)
        {
            this.Username = username;
            this.Email = email;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
