namespace KT1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "Война и мир", "Преступление и наказание", "Евгений Онегин" };
            Library library = new Library("Санкт-Петербург, Невский проспект, 1", books);

            Reader reader = new Reader("Sava", "Sheglov", 52);

            reader.ReadBook(library, "Война и мир");       
            reader.ReadBook(library, "Мастер и Маргарита"); 
        }
    }
}