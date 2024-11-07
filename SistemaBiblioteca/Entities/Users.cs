using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class Users
    {
   
        public string ID {  get; set; }

        public string  Name { get; set; }
        public string Address { get; set; }
        
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public string Identity { get; set; }

        public Users(string iD, string name, string address, string phoneNumber, string email, string identity)
        {
            ID = iD;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Identity = identity;
        }

        public override string ToString()
        {
            return $"nombre del usuario {Name}, identidad {Identity}, ID {ID}, Direccion {Address}, NumeroTelefonico {PhoneNumber}, CorreoElectronico {Email}";
        }
    }
}
