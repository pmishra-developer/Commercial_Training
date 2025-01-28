using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public abstract class Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }

        public abstract double GetArea();
        
    }

    public class Square: Shape
    {
        public Square(double Len, double Bre)
        {
            Length = Len;
            Breadth = Bre;
        }

        public override double GetArea()
        {
            return Length * Breadth;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double Len, double Bre, double Hht)
        {
            Length = Len;
            Breadth = Bre;
            Height = Hht;
        }

        public override double GetArea()
        {
            return Length * Breadth * Height;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double Bre, double Hht)
        {
            Breadth = Bre;
            Height = Hht;
        }

        public override double GetArea()
        {
            return (Breadth * Height) / 2 ;
        }
    }

}



