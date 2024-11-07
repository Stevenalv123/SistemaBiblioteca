using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class Editorial
    {
        public int Id_Editorial { get; set; }  
        public string Name { get; set; }  
        public string Adress { get; set; }
        public string Phone_Number { get; set; } 
        public string Email { get; set; }

        public Editorial(int id_Editorial, string name, string adress, string phone_Number, string email)
        {
            Id_Editorial = id_Editorial;
            Name = name;
            Adress = adress;
            Phone_Number = phone_Number;
            Email = email;
        }
    }
}
