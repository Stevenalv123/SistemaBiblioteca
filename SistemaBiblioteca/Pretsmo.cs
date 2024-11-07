using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public  class Pretsmo
{ 
      

    public string IDPrestamo { get; set; }
         public string Nombre { get; set; }
         public string IDUsuario { get; set; }
         public string IDLibro { get; set; }
         public string FechaPrestamo { get; set; }
         public string FechaDevolucion { get; set; }

    public Pretsmo(string iDPrestamo, string nombre, string iDUsuario, string iDLibro, string fechaPrestamo, string fechaDevolucion)
    {
        IDPrestamo = iDPrestamo;
        Nombre = nombre;
        IDUsuario = iDUsuario;
        IDLibro = iDLibro;
        FechaPrestamo = fechaPrestamo;
        FechaDevolucion = fechaDevolucion;
    }
    public override string ToString()
    {
        return $"IDPrestamo {IDPrestamo}, Nombre {Nombre}, IDUsuario {IDUsuario}, IDLibro {IDLibro}, FechaPretamo {FechaPrestamo}, FechaDevolucion {FechaDevolucion}";
    }

}

