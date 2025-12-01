
namespace BookApp
{
    public class App
    {
        BookManager manager = new BookManager();

        public void Run()
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine("==== Book Manager ====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Show Books");
                Console.WriteLine("3. Exit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddBookMenu();
                }
                else if (choice == "2")
                {
                    manager.ShowBooks();
                }
                else if (choice == "3")
                {
                    run = false;
                }
            }
        }

        private void AddBookMenu()
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            Console.Write("Enter author: ");
            string author = Console.ReadLine();

            manager.AddBook(title, author);

            Console.WriteLine("Book added!\n");
        }
    }
}
