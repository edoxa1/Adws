using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adws
{
    class Person : IPrint
    {
        private string name = "Person";
        public void Print()
        {
            Console.WriteLine(name);
        }
    }
}
