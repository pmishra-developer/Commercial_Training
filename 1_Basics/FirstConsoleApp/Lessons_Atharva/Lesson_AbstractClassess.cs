using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Atharva
{
    //Abstract Class
    public abstract class Animal  //Ex1
    {
        //Abstract method
        public abstract void makeSound();
  
    }

    //Child Class Dog
    public class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Abstract class
    public abstract class Shape   //Ex2
    {
        public abstract void Draw();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>() 
            { 
                new Circle(),
                new Rectangle(),
            };
            foreach(Shape s in list)
            {
                s.Draw();
            }

            Dog dog = new Dog();
            dog.makeSound();
        }
    }
}
