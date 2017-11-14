using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreePigsTaleV2
{
    abstract class Animal
    {
        public string Name { get; }

        public Animal(string name)
        {
            Name = name;
        }
    }
}
