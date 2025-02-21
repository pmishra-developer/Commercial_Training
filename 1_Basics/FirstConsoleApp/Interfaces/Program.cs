using Interfaces;

namespace FirstConsoleApp;

static class Program
{
    static void Main(string[] args)
    {
        Dog Dog = new Dog("Dog");
        Console.WriteLine(Dog.GetName());

        Cat cat = new Cat("Cat", "Meow");
        Console.WriteLine(cat.GetName());
        Console.WriteLine(cat.GetNature());


        Console.ReadKey();
    }
}