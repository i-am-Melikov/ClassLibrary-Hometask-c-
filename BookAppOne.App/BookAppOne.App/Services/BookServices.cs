using BookAppOne.Core.Models;
namespace BookAppOne.App.Services
{
    internal class BookServices
    {
        private Book[] books = new Book[0];


        public void CreateBook()
        {
            Book NewBook = new Book();
            Console.WriteLine("Add Name");
            NewBook.Name = (Console.ReadLine());
            Console.WriteLine("Add Price");
            NewBook.Price = int.Parse(Console.ReadLine());

            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = NewBook;
        }

        public void ShowBooks()
        {
            if (books.Length==0)
            {
                Console.WriteLine("No any book");
            }
            foreach (Book NewBook in books)
            {
                NewBook.GetFullInfo();
            }

        }

    }
}


