using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adws
{
    class Student : IPrint, ICalc
    {
        private int[] marks = new int[] { 90,90,75,50,90 };
        private string name = "Student";
        private int sum = 0;
        public void Print()
        {
            Console.WriteLine("Название класса: " + name);
        }
        public void Calculate()
        {
            foreach(int a in marks)
            {
                sum += a;
            }
            Console.WriteLine($"Среднее значние: {(sum / marks.Length)}");
        }
    }
}
