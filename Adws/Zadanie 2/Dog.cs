using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adws
{
    class Dog : IAnimalEnergy
    {
        public int energy = 100;
        public void Eat()
        {
            Console.WriteLine($"Собака. Энергии: {energy}");
            energy = energy + 50;
            Console.WriteLine($"Поесть: Энергия +50 = {energy}");
        }
        public void Walk()
        {
            Console.WriteLine($"Собака. Энергии: {energy}");
            energy = energy - 75;
            Console.WriteLine($"Походить: -75 = {energy}");
        }
    }
}
