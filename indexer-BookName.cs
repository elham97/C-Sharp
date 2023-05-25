namespace BookName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookName book = new BookName(2);
            book[0, "python"]= "usif";
            book[1, "c#"] ="ali";
            Console.WriteLine(book[0, "python"]);

        }
    }
}