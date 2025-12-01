

namespace BookApp
{
    public class BookManager
    {
        private List<Book> books = new List<Book>();

        public void AddBook(string title, string author)
        {
            Book b = new Book();
            b.Title = title;
            b.Author = author;

            books.Add(b);
        }

        public void ShowBooks()
        {
            Console.WriteLine("=== Books ===");

            if (books.Count == 0)
            {
                Console.WriteLine("No books yet.\n");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine("Title: " + book.Title + " | Author: " + book.Author);
            }

            Console.WriteLine();
        }
    }
}
