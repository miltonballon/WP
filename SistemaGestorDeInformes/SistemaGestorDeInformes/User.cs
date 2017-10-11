using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    public class User
    {
        private String email;
        private String name;
        private String password;

        public User(string email, string name, string password)
        {
            this.email = email;
            this.name = name;
            this.password = password;
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
       
    }
}
