using MyHelperLibrary.Helpers;
using PB20104062024.Models;
using PB20104062024.Models.TestModels2;
using Test = PB20104062024.Models.TestModels2.Test;
namespace PB20104062024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Programming");
            book.AuthorName = "Abbas";
            book.PageCount = 1;
            Book book2 = new Book("Design");
            book.AuthorName = "Sah Abbas";
            book.PageCount = 12;

            Console.WriteLine(book.Code);

            Library library = new Library();
            library.AddBook(book);
            library.AddBook(book2);


            library[1] = new Book("Cyber");

            Console.WriteLine(library[1]);

            Test test = new Test();
            Console.WriteLine(test.Surname);


        }
    }
}
