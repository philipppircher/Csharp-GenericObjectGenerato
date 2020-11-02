using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectGeneratorProject.Classes
{
    class Animal
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            this.Name = name;
        }
    }
}
