using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class Author
    {
        public string Id_Author { get; set; }
        public string Name { get; set; }
        public string Nacionality { get; set; }
        public string Year_birth { get; set; }

        public Author(string id_Author, string name, string nacionality, string year_birth)
        {
            Id_Author = id_Author;
            Name = name;
            Nacionality = nacionality;
            Year_birth = year_birth;
        }
    }
}
