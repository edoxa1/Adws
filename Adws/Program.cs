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
            Teacher tea = new Teacher();
            tea.Print();
            Person per = new Person();
            per.Print();
            Student stud = new Student();
            stud.Print();
            stud.Calculate();
            Console.WriteLine("-----------Задание 2---------");
            Dog dog = new Dog();
            dog.Eat();
            dog.Walk();
            Cat cat = new Cat();
            cat.Eat();
            cat.Walk();
            Giraffe gir = new Giraffe();
            gir.Eat();
            gir.Walk();
            Console.ReadKey();
        }
    }
}
