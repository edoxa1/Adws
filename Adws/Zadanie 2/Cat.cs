using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adws
{
    class Cat : IAnimalEnergy
    {
        public int energy = 75;
        public void Eat()
        {
            Console.WriteLine($"Кот. Энергии: {energy}");
            energy = energy + 100;
            Console.WriteLine($"Поесть: Энергия +50 = {energy}");
        }
        public void Walk()
        {
            Console.WriteLine($"Кот. Энергии: {energy}");
            energy = energy - 25;
            Console.WriteLine($"Походить: -75 = {energy}");
        }
    }
}
