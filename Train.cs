using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        public List<Wagon> Wagons;
        private List<Animal> Animals {get;}
        public Train()
        {
            Wagons = new List<Wagon>()
            {
                new Wagon()
            };
            Animals = new List<Animal>();
        }

        public void SortAnimals(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                Animals.Add(animal);
            }
            DistributeAnimals();
        }

        private void DistributeAnimals()
        {
            TryAddAnimalsToWagons(SortCarnivores());
            TryAddAnimalsToWagons(SortMediumHerbivores());
            TryAddAnimalsToWagons(SortSmallHerbivores());
            TryAddAnimalsToWagons(SortLargeHerbivores());
        }

        private List<Animal> SortCarnivores()
        {
            return Animals
                 .Where(animal => animal.Type == AnimalType.Carnivore)
                 .OrderBy(animal => animal.Size)
                 .ToList();
        }

        private List<Animal> SortSmallHerbivores()
        {
            return Animals
                .Where(animal => animal.Type == AnimalType.Herbivore && animal.Size == AnimalSize.Small)
                .OrderByDescending(animal => animal.Size)
                .ToList();
        }

        private List<Animal> SortMediumHerbivores()
        {
            return Animals
                .Where(animal => animal.Type == AnimalType.Herbivore && animal.Size == AnimalSize.Medium)
                .ToList();
        }

        private List<Animal> SortLargeHerbivores()
        {
            return Animals
                .Where(animal => animal.Type == AnimalType.Herbivore && animal.Size == AnimalSize.Large)
                .ToList();
        }

        public void TryAddAnimalsToWagons(List<Animal> animalList)
        {
            foreach (Animal animal in animalList)
            {
                if (Wagons.Any(wagon => wagon.TryAddAnimal(animal))) { }

                else
                {
                    AddToNewWagon(animal);

                }
            }
        }

        private void AddToNewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagon.TryAddAnimal(animal);
            Wagons.Add(wagon);
        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("");
            builder.AppendLine("          +------+          ");
            builder.AppendLine("          |  {}  |          ");
            builder.AppendLine("         X|      |X         ");
            builder.AppendLine("         X|      |X         ");
            builder.AppendLine("          |      |          ");
            builder.AppendLine("        +-+      +-+        ");
            builder.AppendLine("        |          |        ");
            builder.AppendLine("       X|          |X       ");
            builder.AppendLine("       X|          |X       ");
            builder.AppendLine("        +----------+        ");

            foreach (var wagon in Wagons)
            {
                builder.Append(wagon.ToString());
            }
            return builder.ToString();
        }
    }
}
