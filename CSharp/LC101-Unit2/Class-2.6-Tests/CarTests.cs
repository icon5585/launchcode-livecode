using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_2._6;
using System;

namespace Class_2._6_Tests
{
    // 6.2.3 [TestClass]
    [TestClass]
    public class CarTests
    {
        Car test_car;

        // 6.2.4 [TestInitialize]
        [TestInitialize]
        public void CreateCarObject()
        {
            Console.WriteLine("Initializing test");
            test_car = new Car("Toyota", "Prius", 10, 50);
        }

        // 6.2.5 [TestCleanup]
        [TestCleanup]
        public void cleanupAfterTest()
        {
            // Note: this is totally unnecessary, just used for teaching
            Console.WriteLine("Cleaning up test");
            test_car = null;
        }

        // 6.2.3 [TestMethod]
        [TestMethod]
        public void EmptyTest()
        {
            // Assert takes in 3 values (expected, actual, and delta) 
            Assert.AreEqual(10, 10, .001);
        }

        [TestMethod]
        public void TestInitialGasTank()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }


    }
}
