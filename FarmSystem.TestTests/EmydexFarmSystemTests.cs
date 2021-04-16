using Microsoft.VisualStudio.TestTools.UnitTesting;
using FarmSystem.Test1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1.Tests
{
    [TestClass()]
    public class EmydexFarmSystemTests
    {
        [TestMethod()]
        public void EnterTest()
        {
            var farm = new EmydexFarmSystem();
            Assert.IsNotNull(farm);
        }

        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void NotImplementedExceptionTest()
        {
            var farm = new EmydexFarmSystem();
            TestAnimal test = new TestAnimal();
            test.ProduceMilk();

        }

        [TestMethod()]
        public void CowCreationTest()
        {
            var farm = new EmydexFarmSystem();
            var cow = new Cow();
            Assert.IsNotNull(cow);
            Assert.AreEqual(cow.NumberOfLegs, 4);
            farm.Enter(cow);
            Assert.AreEqual(farm.AnimalsCurrentlyInFarm(), 1);
        }
        public void HenCreationTest()
        {
            var farm = new EmydexFarmSystem();
            var hen = new Hen();
            Assert.IsNotNull(hen);
            Assert.AreEqual(hen.NumberOfLegs, 2);
            farm.Enter(hen);
            Assert.AreEqual(farm.AnimalsCurrentlyInFarm(), 1);
        }
        public void HorseCreationTest()
        {
            var farm = new EmydexFarmSystem();
            var horse = new Horse();
            Assert.IsNotNull(horse);
            Assert.AreEqual(horse.NumberOfLegs, 4);
            farm.Enter(horse);
            Assert.AreEqual(farm.AnimalsCurrentlyInFarm(), 1);
        }

        public void SheepCreationTest()
        {
            var farm = new EmydexFarmSystem();
            var sheep = new Sheep();
            Assert.IsNotNull(sheep);
            Assert.AreEqual(sheep.NumberOfLegs, 4);
            farm.Enter(sheep);
            Assert.AreEqual(farm.AnimalsCurrentlyInFarm(), 1);
        }

        [TestMethod()]
        public void MakeNoiseTest()
        {
            var farm = new EmydexFarmSystem();
            Cow cow = new Cow();
            farm.Enter(cow);

            Hen hen = new Hen();
            farm.Enter(hen);

            Horse horse = new Horse();
            farm.Enter(horse);

            Sheep sheep = new Sheep();
            farm.Enter(sheep);
            Assert.AreEqual(farm.AnimalsCurrentlyInFarm(), 4);
            farm.MakeNoise();
        }

        [TestMethod()]
        public void MilkAnimalsTest()
        {
            var farm = new EmydexFarmSystem();
            Cow cow = new Cow();
            farm.Enter(cow);

            Hen hen = new Hen();
            farm.Enter(hen);

            Horse horse = new Horse();
            farm.Enter(horse);

            Sheep sheep = new Sheep();
            farm.Enter(sheep);
            Assert.AreEqual(farm.AnimalsCurrentlyInFarm(), 4);
            farm.MilkAnimals();
        }

        [TestMethod()]
        public void ReleaseAllAnimalsTest()
        {
            var farm = new EmydexFarmSystem();
            Cow cow = new Cow();
            farm.Enter(cow);

            Hen hen = new Hen();
            farm.Enter(hen);

            Horse horse = new Horse();
            farm.Enter(horse);

            Sheep sheep = new Sheep();
            farm.Enter(sheep);
            Assert.AreEqual(farm.AnimalsCurrentlyInFarm(), 4);
            farm.ReleaseAllAnimals();
            Assert.AreEqual(farm.AnimalsCurrentlyInFarm(), 0);

        }
    }
}