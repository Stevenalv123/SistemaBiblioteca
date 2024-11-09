using SistemaBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum State
{
    Disponible,
    Prestado,
    Reparacion,
    Perdido
}
public class Book:IBook
{
    public string Id_Book { get; set; }
    public string Title { get; set; }
    public Author Author{ get; set; }
    public Categorie Categorie { get; set; }
    public string ISBN { get; set; }
    public Editorial Editorial { get; set; }
    public int YearPublication { get; set; }
    public State BookState { get; set; }

    public Book(string id_Book, string title, Author author, Categorie categorie, string iSBN, Editorial editorial, int yearPublication, State bookState)
    {
        Id_Book = id_Book;
        Title = title;
        Author = author;
        Categorie = categorie;
        ISBN = iSBN;
        Editorial = editorial;
        YearPublication = yearPublication;
        BookState = bookState;
    }

    public void AddBook()
    {
        throw new NotImplementedException();
    }

    public void UpdateBook()
    {
        throw new NotImplementedException();
    }

    public void DeleteBook()
    {
        throw new NotImplementedException();
    }

    public void GetBook()
    {
        throw new NotImplementedException();
    }
}