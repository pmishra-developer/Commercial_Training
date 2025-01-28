namespace FirstConsoleApp;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Crow crow = new Crow();
        crow.Type("crow");
        crow.Nature("flying");
        crow.Count(5, 5);
        crow.Variety(2);

        Console.ReadKey();
    }
}