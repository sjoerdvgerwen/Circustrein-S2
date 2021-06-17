using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Circustrein.Unittests
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void Adds_Herbivore_In_New_Wagon_When_Other_Wagon_Is_Full()
        {
            Train train = new Train();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));

            train.TryAddAnimalsToWagons(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void Adds_Carnivore_In_New_Wagon_When_Other_Wagon_Is_Full()
        {
            Train train = new Train();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Carnivore(AnimalSize.Large));
            animals.Add(new Carnivore(AnimalSize.Large));
            animals.Add(new Carnivore(AnimalSize.Large));
            animals.Add(new Carnivore(AnimalSize.Large));

            train.TryAddAnimalsToWagons(animals);

            Assert.AreEqual(4, train.Wagons.Count);
        }

        [TestMethod]
        public void Big_Carnivore_Will_Not_Go_In_Same_Wagon_As_Smaller_Carnivore()
        {
            Train train = new();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Carnivore(AnimalSize.Large));
            animals.Add(new Carnivore(AnimalSize.Small));

            train.TryAddAnimalsToWagons(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void Big_Herbivore_Will_Not_Go_In_Same_Wagon_As_Big_Carnivore()
        {
            Train train = new();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Carnivore(AnimalSize.Large));
            animals.Add(new Carnivore(AnimalSize.Large));

            train.TryAddAnimalsToWagons(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void Wagon_Is_Build_With_Max_10_Capacity()
        {
            Wagon wagon = new Wagon();

            Assert.IsNotNull(wagon);
            Assert.AreEqual(10, wagon.MaxCapacity);
        }

        [TestMethod]
        public void Cant_Add_Large_Carnivore_With_Large_Herbivore()
        {
            Wagon wagon = new Wagon();
            Animal Carnivore = new Carnivore(AnimalSize.Large);
            Animal Herbivore = new Carnivore(AnimalSize.Large);

            wagon.TryAddAnimal(Carnivore);

            Assert.IsFalse(wagon.TryAddAnimal(Herbivore));
        }

        [TestMethod]
        public void Cant_Add_Small_Carnivore_With_Large_Carnivore()
        {
            Wagon wagon = new Wagon();
            Animal CarnivoreBig = new Carnivore(AnimalSize.Large);
            Animal CarnivoreSmall = new Carnivore(AnimalSize.Small);

            wagon.TryAddAnimal(CarnivoreBig);

            Assert.IsFalse(wagon.TryAddAnimal(CarnivoreSmall));
        }

        [TestMethod]
        public void Cant_Add_Animal_If_Capacity_Is_Higher_Then_10()
        {
            Wagon wagon = new Wagon();
            Animal a1 = new Herbivore(AnimalSize.Large);
            Animal a2 = new Herbivore(AnimalSize.Large);
            Animal a3 = new Herbivore(AnimalSize.Large);

            wagon.TryAddAnimal(a1);
            wagon.TryAddAnimal(a2);

            Assert.IsFalse(wagon.TryAddAnimal(a3));
        }

        [TestMethod]
        public void Does_The_Current_Capacity_Change_When_Animal_Is_Added()
        {
            Wagon wagon = new Wagon();
            Animal a1 = new Carnivore(AnimalSize.Medium);
            Animal a2 = new Herbivore(AnimalSize.Large);

            wagon.TryAddAnimal(a1);
            wagon.TryAddAnimal(a2);

            Assert.AreEqual(8, wagon.CurrentCapacity);
        }
    }
}
