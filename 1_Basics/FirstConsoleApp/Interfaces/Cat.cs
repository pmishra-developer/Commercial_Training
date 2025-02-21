using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cat(string nme, string snd) : IAnimal, INature
    {
        public string Name { get; set; } = nme;
        public string Sound { get; set; } = snd;

        public string GetName() { return Name; }
        public string GetNature() { return Sound; }


    }
}
