using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectGeneratorProject.Classes
{
    class MyBase
    {
        public string Name { get; private set; }
        public MyBase()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
