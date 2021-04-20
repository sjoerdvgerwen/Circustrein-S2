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

        public List<Animal> Animals { get; set; }

        public Animal(AnimalSize size, AnimalType type)
        {

            Size = size;
            Type = type;
        }

        public Animal(List<Animal> UnsortedAnimals)
        {
            var sortedAnimals = UnsortedAnimals
                .OrderBy(animals => animals.Size == AnimalSize.Small)
                .ThenBy(animals => animals.Size == AnimalSize.Large)
                .ThenBy(animals => animals.Size == AnimalSize.Medium);


            Animals = sortedAnimals.ToList();
        }

        public void SortByTypeAndSize(IEnumerable<Animal> animalCollection)
        {
            IEnumerable<Animal> carnivores = (List<Animal>)animalCollection
                .Where(animal => animal.Type == AnimalType.Carnivore);
            IEnumerable<Animal> herbivores = animalCollection
                .Where(animal => animal.Type == AnimalType.Herbivore)
                .OrderBy(animal => animal.Size)
                .ToList();
        }
    }
}
