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

        public string Nombre { get; set; }
        public string Direccion { get; set; }
        
        public string NumeroTelefonico { get; set; }
        public string CorreoElectronico {  get; set; }
        public string Identidad { get; set; }

        public Users(string iD, string nombre, string direccion, string numeroTelefonico, string correoElectronico, string identidad)
        {
            ID = iD;
            Nombre = nombre;
            Direccion = direccion;
            NumeroTelefonico = numeroTelefonico;
            CorreoElectronico = correoElectronico;
            Identidad = identidad;
        }

        public override string ToString()
        {
            return $"nombre del usuario {Nombre}, identidad {Identidad}, ID {ID}, Direccion {Direccion}, NumeroTelefonico {NumeroTelefonico}, CorreoElectronico {CorreoElectronico}";
        }
    }
}
