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
            

            Animal animal = new Animal(animals);
            var sortedAnimals = animal.Animals;

            Train train = new Train();
            train.AddAnimalToWagon(sortedAnimals);
            Console.WriteLine(train);
        }
    }
}
