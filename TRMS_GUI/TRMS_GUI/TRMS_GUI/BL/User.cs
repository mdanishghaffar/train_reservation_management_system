using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMS.BL
{
    class User
    {
        protected string username;
        protected string password;
        protected string role;
        public User(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;

        }
        public User()
        {

        }

        public string Username
        {
            get => getUsername();
        }

        public string Password
        {
            get => getPassword();
        }

        public string Role
        {
            get => getRole();
        }

        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public virtual string getRole()
        {
            return this.role;
        }
        public void setRole(string role)
        {
            this.role = role;
        }
    }
}
