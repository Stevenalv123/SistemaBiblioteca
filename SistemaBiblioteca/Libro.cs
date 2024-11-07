using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Libro
{
   

    public string IDLibro { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public string ISBN { get; set; }
    public string Editorial { get; set; }
    public int AñoPublicacion { get; set; }
    public string Estado { get; set; }

    public Libro(string iDLibro, string titulo, string autor, string genero, string iSBN, string editorial, int añoPublicacion, string estado)
    {
        IDLibro = iDLibro;
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        ISBN = iSBN;
        Editorial = editorial;
        AñoPublicacion = añoPublicacion;
        Estado = estado;
    }
    public override string ToString()
    {
        return $"IDLibro {IDLibro}, Titulo {Titulo}, Autor {Autor}, Genero {Genero}, ISBN {ISBN}, Editorial {Editorial}, añoPublcacion {AñoPublicacion}, Estado {Estado}"; 
    }


}