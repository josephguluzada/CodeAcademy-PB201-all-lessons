namespace LibraryBookTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Harry Potter", 15, "Fantastic");
            Book book2 = new Book(2, "Serenad", 19.99, "Dram");
            Book book3 = new Book(3, "Elxan Elatli", 9.99, "Biography");
            Book book4 = new Book(4, "Elxan Agatli", 99.99, "Dram");


            Library pb201 = new Library();
            
            pb201.AddBook(book1);
            pb201.AddBook(book2);
            pb201.AddBook(book3);
            pb201.AddBook(book4);

            //foreach (Book book in pb201.Books)
            //{
            //    Console.WriteLine(book.Id + " " + book.Name);
            //}


            //foreach (var book in pb201.GetFilteredBooks("fantastic"))
            //{
            //    Console.WriteLine(book.Name + " " + book.Genre);
            //}

            //Book? wantedBook = pb201.GetBookById(1);

            //Console.WriteLine(wantedBook?.Name);

            //if(wantedBook == null)
            //{
            //    Console.WriteLine("Book not found!");
            //}
            //else
            //{
            //    Console.WriteLine(wantedBook.Name);
            //}
            //Book? wantedBookByName = pb201.GetBookByName(null);

            //Console.WriteLine(wantedBookByName?.Id +  " - " + wantedBookByName?.Name);

            //foreach (var item in pb201.GetFilteredBooks(0,200))
            //{
            //    Console.WriteLine(item.Name + " " + item.Price);
            //}
        }
    }
}
