using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookTask
{
    public class Library
    {
        // Books[0] = book
        // Books[1] = book
        //public Book[] Books = Array.Empty<Book>();
        public Book[] Books = new Book[0]; // 1

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length -1] = book;
        }

        public Book? GetBookById(int id)
        {
            Book? wantedBook = null;
            if(id > 0)
            {
                foreach (Book book in Books)
                {
                    if(book.Id == id)
                    {
                        wantedBook = book;
                    }
                }
            }
            return wantedBook;
        }
       
        public Book? GetBookByName(string? name)
        {
            Book? wantedBook = null;
            
            if(!string.IsNullOrEmpty(name))
            {
                foreach (var book in Books)
                {
                    if(book.Name.ToLower() == name.Trim().ToLower())
                    {
                        wantedBook = book;
                    }
                }
            }
            return wantedBook;
        }

        public Book[] GetFilteredBooks(string genreName)
        {
            Book[] filteredBooks = Array.Empty<Book>();

            if(!string.IsNullOrEmpty(genreName))
            {
                foreach (var book in Books)
                {
                    if (book.Genre.ToLower() == genreName.ToLower())
                    {
                        Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                        filteredBooks[filteredBooks.Length - 1] = book;
                    }
                }
            }

            return filteredBooks;
        }

        public Book[] GetFilteredBooks(double minPrice, double maxPrice)
        {
            Book[] filteredBooks = Array.Empty<Book>();

            if(minPrice <= maxPrice && minPrice >=0 && maxPrice >= 0)
            {
                foreach (var book in Books)
                {
                    if (book.Price >= minPrice && book.Price <= maxPrice)
                    {
                        Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                        filteredBooks[filteredBooks.Length - 1] = book;
                    }
                }
            } 

            return filteredBooks;
        }
    }
}
