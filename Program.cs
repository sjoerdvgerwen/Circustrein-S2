using System;
using System.Collections.Generic;

namespace Circustrein
{
    class Program
    { 
        static void Main(string[] args)
        {
            Train train = new Train();

            List<Animal> animals = new List<Animal>();

                animals.Add(new Herbivore(AnimalSize.Large));
                animals.Add(new Herbivore(AnimalSize.Medium));
                animals.Add(new Herbivore(AnimalSize.Small));
                animals.Add(new Herbivore(AnimalSize.Small));
                animals.Add(new Herbivore(AnimalSize.Large));
                animals.Add(new Carnivore(AnimalSize.Small));
                animals.Add(new Carnivore(AnimalSize.Medium));
                animals.Add(new Carnivore(AnimalSize.Medium));
                animals.Add(new Carnivore(AnimalSize.Medium));
                animals.Add(new Carnivore(AnimalSize.Large));
                animals.Add(new Carnivore(AnimalSize.Large));

            train.SortAnimals(animals);

            Console.WriteLine(train);
        }
    }
}
