//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;
//using System.Linq;

//namespace Circustrein.Unittests
//{
//    [TestClass]

//    public class TrainTest
//    {
//        [TestMethod]
//        public void INTEGRATION_TEST_ONE() 
//            //naam wijzigen
//            //OO methodes verdelen per klasse
//            //
//        {
            
//            Train train = new Train();
//            List<Animal> herbivores = new List<Animal>();
//            herbivores.Add(new Herbivore(AnimalSize.Small));
//            herbivores.Add(new Herbivore(AnimalSize.Small));
//            herbivores.Add(new Herbivore(AnimalSize.Small));
//            herbivores.Add(new Herbivore(AnimalSize.Small));
//            herbivores.Add(new Herbivore(AnimalSize.Small));
//            herbivores.Add(new Herbivore(AnimalSize.Medium));
//            herbivores.Add(new Herbivore(AnimalSize.Medium));
//            herbivores.Add(new Herbivore(AnimalSize.Medium));
//            herbivores.Add(new Herbivore(AnimalSize.Large));
            


//            Animal animal = new Animal();

//            animal.SortAnimals(herbivores);

//            train.AddAnimalToWagon(animal.SortAnimals(herbivores));

//            Assert.AreEqual(2, train.wagons.Count);
//        }

//        [TestMethod]

//        public void INTEGRATION_TEST_TWO()
//        {
//            List<Animal> animals = new List<Animal>();
//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Carnivore(AnimalSize.Small));
//            animals.Add(new Carnivore(AnimalSize.Medium));
//            animals.Add(new Carnivore(AnimalSize.Medium));
//            animals.Add(new Carnivore(AnimalSize.Medium));
//            animals.Add(new Carnivore(AnimalSize.Large));
//            animals.Add(new Carnivore(AnimalSize.Large));

//            Train train = new Train();

//            Animal animal = new Animal();

//            animal.SortAnimals(animals);

//            train.AddAnimalToWagon(animal.SortedAnimals);

//            Assert.AreEqual(6, train.wagons.Count);
//        }

//        [TestMethod]
//        public void INTEGRATION_TEST_THREE()
//        {

//            List<Animal> animals = new List<Animal>();

//            animals.Add(new Herbivore(AnimalSize.Small));
//            animals.Add(new Herbivore(AnimalSize.Small));
//            animals.Add(new Herbivore(AnimalSize.Small));
//            animals.Add(new Herbivore(AnimalSize.Small));
//            animals.Add(new Herbivore(AnimalSize.Small));

//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));

//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));

//            animals.Add(new Carnivore(AnimalSize.Small));
//            animals.Add(new Carnivore(AnimalSize.Small));

//            animals.Add(new Carnivore(AnimalSize.Medium));
//            animals.Add(new Carnivore(AnimalSize.Medium));

//            animals.Add(new Carnivore(AnimalSize.Large));
//            animals.Add(new Carnivore(AnimalSize.Large));


//            Train train = new Train();

//            Animal animal = new Animal();

//            animal.SortAnimals(animals);

//            train.AddAnimalToWagon(animal.SortedAnimals);

//            Assert.AreEqual(8, train.wagons.Count);
//        }


//        [TestMethod]
//        public void INTEGRATION_TEST_FOUR()
//        {
//            List<Animal> animals = new List<Animal>();

//            animals.Add(new Herbivore(AnimalSize.Small));
//            animals.Add(new Herbivore(AnimalSize.Small));
//            animals.Add(new Herbivore(AnimalSize.Small));
//            animals.Add(new Herbivore(AnimalSize.Small));
//            animals.Add(new Herbivore(AnimalSize.Small));

//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));

//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));

//            animals.Add(new Carnivore(AnimalSize.Small));
//            animals.Add(new Carnivore(AnimalSize.Small));

//            animals.Add(new Carnivore(AnimalSize.Medium));
//            animals.Add(new Carnivore(AnimalSize.Medium));

//            animals.Add(new Carnivore(AnimalSize.Large));
//            animals.Add(new Carnivore(AnimalSize.Large));

//            Train train = new Train();
            
//            Animal animal = new Animal();

//            animal.SortAnimals(animals);

//            train.AddAnimalToWagon(animal.SortedAnimals);

//            Assert.AreEqual(8, train.wagons.Count);
//        }

//        [TestMethod]
//        public void INTEGRATION_TEST_FIVE()
//        {
//            List<Animal> animals = new List<Animal>();

//            animals.Add(new Herbivore(AnimalSize.Small));

//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));

//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));


//            Train train = new Train();

//            Animal animal = new Animal();

//            animal.SortAnimals(animals);

//            train.AddAnimalToWagon(animal.SortedAnimals);

//            Assert.AreEqual(2, train.wagons.Count);
//        }

//        [TestMethod]
//        public void INTEGRATION_TEST_SIX()
//        {
//            List<Animal> animals = new List<Animal>();


//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));
//            animals.Add(new Herbivore(AnimalSize.Medium));
            

//            animals.Add(new Herbivore(AnimalSize.Large));
//            animals.Add(new Herbivore(AnimalSize.Large));
            
//            animals.Add(new Carnivore(AnimalSize.Small));
            
//            Train train = new Train();

//            Animal animal = new Animal();

//            animal.SortAnimals(animals);

//            train.AddAnimalToWagon(animal.SortedAnimals);

//            Assert.AreEqual(2, train.wagons.Count);
//        }
//    }
//}
