//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;

//namespace Circustrein.Unittests
//{
//    [TestClass]
//    public class WagonTest
//    {

//        [TestMethod]
//        public void Wagon_Is_Build_With_Max_10_Capacity()
//        {
//            Wagon wagon = new Wagon();

//            Assert.IsNotNull(wagon);
//            Assert.AreEqual(10, wagon.MaxCapacity);
//        }



//        [TestMethod]
//        public void Cant_Add_Large_Carnivore_With_Large_Herbivore()
//        {
//            Wagon wagon = new Wagon();
//            Animal Carnivore = new Animal(AnimalSize.Large, AnimalType.Carnivore);
//            Animal Herbivore = new Animal(AnimalSize.Large, AnimalType.Herbivore);

//            wagon.CanAnimalBeAddedToWagon(Carnivore);

//            Assert.IsFalse(wagon.CanAnimalBeAddedToWagon(Herbivore));
//        }


//        [TestMethod]
//        public void Cant_Add_Small_Carnivore_With_Large_Carnivore()
//        {
//            Wagon wagon = new Wagon();
//            Animal CarnivoreBig = new Animal(AnimalSize.Large, AnimalType.Carnivore);
//            Animal CarnivoreSmall = new Animal(AnimalSize.Small, AnimalType.Carnivore);

//            wagon.CanAnimalBeAddedToWagon(CarnivoreBig);

//            Assert.IsFalse(wagon.CanAnimalBeAddedToWagon(CarnivoreSmall));
//        }


//        [TestMethod]
//        public void Cant_Add_Animal_If_Capacity_Is_Higher_Then_10()
//        {
//            Wagon wagon = new Wagon();
//            Animal a1 = new Animal(AnimalSize.Large, AnimalType.Herbivore);
//            Animal a2 = new Animal(AnimalSize.Large, AnimalType.Herbivore);
//            Animal a3 = new Animal(AnimalSize.Large, AnimalType.Herbivore);


//            wagon.CanAnimalBeAddedToWagon(a1);
//            wagon.CanAnimalBeAddedToWagon(a2);


//            Assert.IsFalse(wagon.CanAnimalBeAddedToWagon(a3));
//        }


//        [TestMethod]
//        public void Does_The_Current_Capacity_Change_When_Animal_Is_Added()
//        {
//            Wagon wagon = new Wagon();
//            Animal a1 = new Animal(AnimalSize.Medium, AnimalType.Carnivore);
//            Animal a2 = new Animal(AnimalSize.Large, AnimalType.Herbivore);


//            wagon.CanAnimalBeAddedToWagon(a1);
//            wagon.CanAnimalBeAddedToWagon(a2);

//            Assert.AreEqual(8, wagon.CurrentCapacity);
//        }


//        [TestMethod]
//        public void Adds_Herbivore_In_New_Wagon_When_Other_Wagon_Is_Full()
//        {
//            Train train = new Train();

//            List<Animal> animals = new List<Animal>();
//            animals.Add(new Animal(AnimalSize.Large, AnimalType.Herbivore));
//            animals.Add(new Animal(AnimalSize.Large, AnimalType.Herbivore));
//            animals.Add(new Animal(AnimalSize.Large, AnimalType.Herbivore));
//            animals.Add(new Animal(AnimalSize.Large, AnimalType.Herbivore));

//            train.AddAnimalToWagon(animals);

//            Assert.AreEqual(2, train.wagons.Count);

//        }


//        [TestMethod]
//        public void Adds_Carnivore_In_New_Wagon_When_Other_Wagon_Is_Full()
//        {
//            Train train = new Train();

//            List<Animal> animals = new List<Animal>();
//            animals.Add(new Animal(AnimalSize.Large, AnimalType.Carnivore));
//            animals.Add(new Animal(AnimalSize.Large, AnimalType.Carnivore));
//            animals.Add(new Animal(AnimalSize.Large, AnimalType.Carnivore));
//            animals.Add(new Animal(AnimalSize.Large, AnimalType.Carnivore));

//            train.AddAnimalToWagon(animals);

//            Assert.AreEqual(4, train.wagons.Count);
//        }
//    }
//}
