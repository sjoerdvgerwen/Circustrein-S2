using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Wagon
    {
        public int MaxCapacity { get; set; }
        private List<Animal> animalsInWagon { get; set; }
        public int CurrentCapacity { get; set; }

        public Wagon()
        {
            animalsInWagon = new List<Animal>();
            MaxCapacity = 10;
        }


        private bool DoesAnimalFit(Animal animal)

        {
            if ((int)animal.Size + CurrentCapacity <= MaxCapacity)
            {
                return true;
            }
            return false;
        }

        private bool CantAddCarnivoreWithCarnivore(Animal animal)
        {
            foreach (Animal animalInWagon in animalsInWagon)
            {
                if (animalInWagon.Type == AnimalType.Carnivore && animal.Type == AnimalType.Carnivore)
                {
                    return false;
                }
            }
            return true;
        }


        private bool SafeToAddAnimal(Animal animal)

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

        public bool TryAddAnimal(Animal animal)
        {
            if (DoesAnimalFit(animal) && CantAddCarnivoreWithCarnivore(animal) && SafeToAddAnimal(animal)) 
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
