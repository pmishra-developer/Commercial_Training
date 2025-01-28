using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    static class Program1
    {
        static void Main(string[] args)
        {

            //Abstract class can never be instantiated directly.
            //Abstract classes can contain both Abstact method and Non Abstact methods
            //If Abstract method is present then the class should also be Abstract class
            //While inheriting the abstract class, the abstract methods should be inherited using the override function in the derived class.
            //All the methods present in the Abstract class can be accessed by inhering it in derived class - By creating an object and accessing its methods in Main function.

            //Abstract class provides set of instructions to be followed by any of its derived class by using the abstract methods which should follow the same in any of its inherited derived classes.

            Square square = new Square(10, 20);
            Console.WriteLine($"Area of square is {square.GetArea()}");

            Rectangle rectangle = new Rectangle(10, 10, 5);
            Console.WriteLine($"Area of rectangle is {rectangle.GetArea()}");

            Triangle triangle = new Triangle(5, 10);
            Console.WriteLine($"Area of triangle is {triangle.GetArea()}");


            List<Shape> list = new List<Shape>();
            list.Add(new Square(10,20));
            list.Add(new Rectangle(10, 10, 5));
            list.Add(new Triangle(5, 10));

            foreach(var shape in list)
            {
                Console.WriteLine(shape.GetArea());
            }


            Console.ReadKey();
        }
    }
}
