using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adws
{
    class Teacher : IPrint
    {
        private string name = "Teacher";
        public void Print()
        {
            Console.WriteLine(name);
        }
    }
}
