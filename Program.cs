using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Compression;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();

            Animal animal = new Animal();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Herbivore(AnimalSize.Small));
            animals.Add(new Herbivore(AnimalSize.Small));
            animals.Add(new Herbivore(AnimalSize.Small));
            animals.Add(new Herbivore(AnimalSize.Small));
            animals.Add(new Herbivore(AnimalSize.Small));
            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Medium));
            animals.Add(new Herbivore(AnimalSize.Medium));
            animals.Add(new Herbivore(AnimalSize.Medium));

            animal.SortAnimals(animals);

            train.AddAnimalToWagon(animal.SortedAnimals);

            Console.WriteLine(train);
        }
    }
}
