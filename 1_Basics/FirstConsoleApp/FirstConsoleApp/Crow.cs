using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Crow : Bird
    {
        public override void Count(int a, int b)
        {
            Console.WriteLine($"Count is {a + b}");
        }

        public override void Variety(int c)
        {
            Console.WriteLine($"Variety is {c}");
        }
    }
}
