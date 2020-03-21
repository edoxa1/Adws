using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adws
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.Print();
            Student stud = new Student();
            stud.Calculate();
            Console.ReadKey();
        }
    }
}
