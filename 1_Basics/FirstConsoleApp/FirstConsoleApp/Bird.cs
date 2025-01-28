using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public abstract class Bird
    {
        public void Type(string a)
        {
            Console.WriteLine($"Type of Bird is {a}");
        }

        public void Nature(string b)
        {
            Console.WriteLine($"Nature of Bird is {b}");
        }

        public abstract void Count(int a , int b);
        public abstract void Variety(int c);
    }
}
