using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
    {
        public int MaxCapacity { get; set; }

        public List<Animal> animalsInWagon;

        public int CurrentCapacity { get; set; }

        public Wagon()
        {
            animalsInWagon = new List<Animal>();
            MaxCapacity = 10;

        }

        public bool IsWagonFull(Animal animal)
        {
            if ((int)animal.Size + CurrentCapacity <= MaxCapacity)
            {
                return true;
            }
            return false;
        }


        public bool IsLargeCarnivorePresent(Animal animal)
        {
            foreach (Animal animalInWagon in animalsInWagon)
            {
                if (animalInWagon.Type == AnimalType.Carnivore && animalInWagon.Size >= animal.Size)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsAnimalACarnivore(Animal animal)
        {
            foreach (Animal animalInWagon in animalsInWagon)
            {
                if (animal.Type == AnimalType.Carnivore)
                {
                    if (animal.Size >= animalInWagon.Size)
                        return false;
                }
            }
            return true;
        }



        public bool AddAnimalToWagon(Animal animal)
        {
            if (IsAnimalACarnivore(animal) == true && IsWagonFull(animal) == true && IsLargeCarnivorePresent(animal) == true)
            {
                animalsInWagon.Add(animal);
                CurrentCapacity += (int)animal.Size;
                return true;
            }

            return false;
        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("             o              ");
            builder.AppendLine("       ======o======        ");
            foreach (Animal animal in animalsInWagon)
            {
                builder.AppendLine("       " + animal.Size + " " + animal.Type.ToString());


            }
            builder.AppendLine("       ======o======        ");

            return builder.ToString();

        }
    }
}
