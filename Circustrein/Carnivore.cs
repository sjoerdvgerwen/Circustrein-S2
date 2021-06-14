using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Carnivore : Animal
    {
        public AnimalSize Size { get; set; }
        public Carnivore(AnimalSize size) : base(size, AnimalType.Carnivore)
        {
            Size = size;
        }
    }
}


