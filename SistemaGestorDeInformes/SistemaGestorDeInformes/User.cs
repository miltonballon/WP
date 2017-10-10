using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeInformes
{
    class User
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

        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}
