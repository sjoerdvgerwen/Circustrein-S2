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

        public List<Animal> SortedAnimals { get; set; }

        public Animal(AnimalSize size, AnimalType type)
        {

            Size = size;
            Type = type;
        }

        public Animal()
        {

        }

        public List<Animal> SortAnimals(IEnumerable<Animal> UnsortedAnimals)
        {
            var carnivores = UnsortedAnimals
                .OrderBy(animal => animal.Type == AnimalType.Carnivore)
                .ThenByDescending(animal => animal.Size);

            var mediumherbivores = UnsortedAnimals
                .OrderBy(animal => animal.Type == AnimalType.Herbivore)
                .ThenByDescending(animal => animal.Size == AnimalSize.Medium);

            var smallherbivores = UnsortedAnimals
                .OrderBy(animal => animal.Type == AnimalType.Herbivore)
                .ThenByDescending(animal => animal.Size == AnimalSize.Small);

            var largeherbivores = UnsortedAnimals
                .OrderBy(animal => animal.Type == AnimalType.Herbivore)
                .ThenByDescending(animal => animal.Size == AnimalSize.Large);


            SortedAnimals = carnivores.ToList();
            SortedAnimals = largeherbivores.ToList();
            SortedAnimals = smallherbivores.ToList();
            SortedAnimals = mediumherbivores.ToList();
            
            return SortedAnimals;

        }
    }
}
