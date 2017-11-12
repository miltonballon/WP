using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Contact
    {
        private int id;
        private String name;
        private String lastname;
        private String phone;
        
        public Contact(int id, string name, string lastname, string phone)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
        }

        public Contact(string name, string lastname, string phone)
        {
            this.name = name;
            this.lastname = lastname;
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
        public string Lastname
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
