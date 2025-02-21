using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Dog(string nme) : IAnimal
    {
        public string name { get; set; } = nme;

        public string GetName()
        {
            return name;

        }

    }
}
