using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    class Contact
    {
        private int id;
        private String name;
        private String Lastname;
        private String phone;
        
        public Contact(int id, string name, string lastname, string phone)
        {
            this.id = id;
            this.name = name;
            Lastname = lastname;
            this.phone = phone;
        }

        public Contact(string name, string lastname, string phone)
        {
            this.name = name;
            Lastname = lastname;
            this.phone = phone;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Lastname1
        {
            get => Lastname;
            set => Lastname = value;
        }
        public string Phone
        {
            get => phone;
            set => phone = value;
        }
    }
}
