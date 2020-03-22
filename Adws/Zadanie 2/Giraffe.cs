using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adws
{
    class Giraffe : IAnimalEnergy
    {
        public int energy = 200;
        public void Eat()
        {
            Console.WriteLine($"Жираф. Энергии: {energy}");
            energy = energy + 75;
            Console.WriteLine($"Поесть: Энергия +50 = {energy}");
        }
        public void Walk()
        {
            Console.WriteLine($"Жираф. Энергии: {energy}");
            energy = energy - 120;
            Console.WriteLine($"Походить: -75 = {energy}");
        }
    }
}
