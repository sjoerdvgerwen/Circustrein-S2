using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Animal
    {
        public AnimalSize Size { get; set; }
        public AnimalType Type { get; set; }

        public Animal(AnimalSize size, AnimalType type)

        {
            Size = size;
            Type = type;
        }

    }
}
