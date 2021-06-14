using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Circustrein.Unittests
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void FiveH1_ThreeH3_OneH5_Returns_2_Wagons()

        {
            Train train = new Train();
            List<Animal> herbivores = new List<Animal>();
            herbivores.Add(new Herbivore(AnimalSize.Small));
            herbivores.Add(new Herbivore(AnimalSize.Small));
            herbivores.Add(new Herbivore(AnimalSize.Small));
            herbivores.Add(new Herbivore(AnimalSize.Small));
            herbivores.Add(new Herbivore(AnimalSize.Small));
            herbivores.Add(new Herbivore(AnimalSize.Medium));
            herbivores.Add(new Herbivore(AnimalSize.Medium));
            herbivores.Add(new Herbivore(AnimalSize.Medium));
            herbivores.Add(new Herbivore(AnimalSize.Large));

            train.SortAnimals(herbivores);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void ThreeH5_OneC1_ThreeC3_TwoC5_Return_6_Wagons()
        {
            Train train = new Train();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Carnivore(AnimalSize.Small));
            animals.Add(new Carnivore(AnimalSize.Medium));
            animals.Add(new Carnivore(AnimalSize.Medium));
            animals.Add(new Carnivore(AnimalSize.Medium));
            animals.Add(new Carnivore(AnimalSize.Large));
            animals.Add(new Carnivore(AnimalSize.Large));

            train.SortAnimals(animals);

            Assert.AreEqual(6, train.Wagons.Count);
        }

        [TestMethod]
        public void FiveH1_FiveH3_FiveH5_TwoC1_TwoC3_TwoC5_Return_8_Wagons()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Herbivore(AnimalSize.Small));
            animals.Add(new Herbivore(AnimalSize.Small));
            animals.Add(new Herbivore(AnimalSize.Small));
            animals.Add(new Herbivore(AnimalSize.Small));
            animals.Add(new Herbivore(AnimalSize.Small));

            animals.Add(new Herbivore(AnimalSize.Medium));
            animals.Add(new Herbivore(AnimalSize.Medium));
            animals.Add(new Herbivore(AnimalSize.Medium));
            animals.Add(new Herbivore(AnimalSize.Medium));
            animals.Add(new Herbivore(AnimalSize.Medium));

            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));

            animals.Add(new Carnivore(AnimalSize.Small));
            animals.Add(new Carnivore(AnimalSize.Small));

            animals.Add(new Carnivore(AnimalSize.Medium));
            animals.Add(new Carnivore(AnimalSize.Medium));

            animals.Add(new Carnivore(AnimalSize.Large));
            animals.Add(new Carnivore(AnimalSize.Large));

            train.SortAnimals(animals);

            Assert.AreEqual(8, train.Wagons.Count);
        }

        [TestMethod]
        public void OneH1_ThreeH3_FiveH5_Return_2_Wagons()
        {
            List<Animal> animals = new List<Animal>();

            Train train = new Train();

            animals.Add(new Herbivore(AnimalSize.Small));

            animals.Add(new Herbivore(AnimalSize.Medium));
            animals.Add(new Herbivore(AnimalSize.Medium));
            animals.Add(new Herbivore(AnimalSize.Medium));

            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));

            train.SortAnimals(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }

        [TestMethod]
        public void ThreeH3_TwoH5_OneC1_Return_2_Wagons()
        {
            List<Animal> animals = new List<Animal>();

            Train train = new Train();

            animals.Add(new Herbivore(AnimalSize.Medium));
            animals.Add(new Herbivore(AnimalSize.Medium));
            animals.Add(new Herbivore(AnimalSize.Medium));

            animals.Add(new Herbivore(AnimalSize.Large));
            animals.Add(new Herbivore(AnimalSize.Large));

            animals.Add(new Carnivore(AnimalSize.Small));

            train.SortAnimals(animals);

            Assert.AreEqual(2, train.Wagons.Count);
        }
    }
}
