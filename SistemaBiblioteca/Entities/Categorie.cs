using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class Categorie
    {
        public int Id_Categorie { get; set; }
        public string Name { get; set; }

        public Categorie(int id_Categorie, string name)
        {
            Id_Categorie = id_Categorie;
            Name = name;
        }
    }
}
