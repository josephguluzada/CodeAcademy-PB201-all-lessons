namespace HomeWork.Models;

public class Library
{
    public List<Book> Books = new List<Book>();

    public Book this[int index]
    {
        get => Books[index];
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public List<Book> FindAllBooksByName(string name)
    {
        return Books.FindAll(book => book.Name.ToLower().Contains(name.ToLower()));
    }

    public Book FindBookByCode(string code)
    {
        //Book? book = Books.FirstOrDefault(book => book.Code == code);
        Book? book = Books.Find(book => book.Code == code);

        if (book is null)
        {
            throw new NullReferenceException("Book not found");
        }

        return book;
    }

    public void RemoveAllBooksByName(string name) 
    { 
        Books.RemoveAll(x=>x.Name.ToLower().Contains(name.ToLower()));
    }

    public List<Book> SearchBooks(string value)
    {

        if(value is not null) 
        {
             return Books.FindAll(x => x.Name.ToLower().Contains(value.ToLower()) || x.AuthorName.ToLower().Contains(value.ToLower()) || x.PageCount.ToString() == value);
        }

        throw new NullReferenceException("Value cannot be null");
    }

    public List<Book> FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
    {
        if(minPageCount <= maxPageCount)
        {
            return Books.FindAll(book => book.PageCount >= minPageCount && book.PageCount <= maxPageCount);
        }
        throw new Exception("MinPageCount must be lower than MaxPageCount");
    }

    public void RemoveBookByCode(string code)
    {
        if(code is not null)
        {
            Book? wantedBook = Books.Find(book => book.Code == code);

            if(wantedBook is not null) 
            {
                Books.Remove(wantedBook);
            }
        }
        throw new NullReferenceException("Book not found!");
    }

}
