using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class AnimalFactory
    {
        private int AmountOfAnimals { get; set; }
        private readonly Random Random = new Random();

        public AnimalFactory(int amountOfAnimals)
        {
            AmountOfAnimals = amountOfAnimals;

        }
    }
}
