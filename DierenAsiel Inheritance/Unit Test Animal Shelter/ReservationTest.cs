using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animal_Shelter;
using Animal_Shelter.Animals;

namespace Unit_Test_Animal_Shelter
{
    [TestClass]
    public class ReservationTest
    {
        private Reservation reservation;

        [TestInitialize]
        public void TestInitialize()
        {
            this.reservation = new Reservation();
        }

        [TestMethod]
        public void TestNewCat()
        {
            //TODO Nieuwe Test voor het aanmaken van een cat
            Cat cat = new Cat("Sgt. Woof", Gender.Male,"Krabt aan gordijnen");
            Assert.AreEqual(cat.Name, "Sgt. Woof");
            Assert.AreEqual(cat.Gender, Gender.Male);
        }

        [TestMethod]
        public void TestNewDog()
        {
            //TODO Nieuwe test voor het aanmaken van een 
            Dog dog = new Dog("Sgt. Woof", Gender.Male);
            Assert.AreEqual(dog.Name, "Sgt. Woof");
            Assert.AreEqual(dog.Gender, Gender.Male);
        }
    }
}
