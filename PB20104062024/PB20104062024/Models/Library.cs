using MyHelperLibrary.Helpers;
using System;

namespace PB20104062024.Models;

public class Library
{
    private Book[] _books;
   
    // Indexer
    public Book this[int index]
    {
        get { return _books[index]; }
        set { _books[index] = value;}
    }
   
    public Library()
    {
        _books = Array.Empty<Book>();
    }


    public void AddBook(Book book)
    {
        Helper.AddItemIntoArray(ref _books, book);
    }

    public Book? FindBookByCode(string code)
    {
        foreach (Book book in _books)
        {
            if (book.Code == code) 
                return book;
        }
        return null;
    }
    public Book[] FindAllBooksByName(string value)
    {
        Book[] newBooks = new Book[0];
        foreach (Book book in _books)
        {
            if (book.Name.ToLower().Contains(value.ToLower()))
            {
                Helper.AddItemIntoArray(ref newBooks, book);
            }
        }
        return newBooks;
    }


    public void RemoveBookByCode(string value)
    {
        bool flag = false;
        Book[] tempBooks = new Book[0];
        foreach (var book in _books)
        {
            if (book.Code.ToLower() == value.ToLower())
                flag = true;
        }

        if (flag)
        {
            foreach (Book book in _books)
            {
                if (book.Code.ToLower() == value.ToLower())
                    continue;
                else
                {
                    Array.Resize(ref tempBooks, tempBooks.Length + 1);
                    tempBooks[^1] = book;
                }
            }
            _books = tempBooks;
        }
    }
}
