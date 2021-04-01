using System;
using System.Collections.Generic;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal((AnimalSize)1, (AnimalType)1));
            animals.Add(new Animal((AnimalSize)3, (AnimalType)2));
            animals.Add(new Animal((AnimalSize)5, (AnimalType)1));
            animals.Add(new Animal((AnimalSize)3, (AnimalType)1));
            animals.Add(new Animal((AnimalSize)3, (AnimalType)2));
            animals.Add(new Animal((AnimalSize)1, (AnimalType)2));
            animals.Add(new Animal((AnimalSize)3, (AnimalType)2));
            animals.Add(new Animal((AnimalSize)5, (AnimalType)2));

            Train train = new Train();
            train.AddAnimalToWagon(animals);
            Console.WriteLine(train);

        }
    }
}
