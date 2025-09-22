// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace KT1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "Война и мир", "Преступление и наказание", "Евгений Онегин" };
            Library library = new Library("Санкт-Петербург, Невский проспект, 1", books);

            Reader reader = new Reader("Andrew", "Andrienko", 69);

            reader.ReadBook(library, "Война и мир");       
            reader.ReadBook(library, "Мастер и Маргарита"); 
        }
    }
}