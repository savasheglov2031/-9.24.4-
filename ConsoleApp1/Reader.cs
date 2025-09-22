
namespace KT1
{
    public class Reader : Person
    {
        public Reader(string firstName, string lastName, int age)
            : base(firstName, lastName, age) { }

        public void ReadBook(Library library, string bookName)
        {
            bool found = false;
            foreach (var book in library.Books)
            {
                if (book.Equals(bookName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Reader {FirstName} {LastName} прочитал книгу \"{bookName}\".");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Книга \"{bookName}\" не найдена в библиотеке {library.Address}.");
            }
        }
    }
}