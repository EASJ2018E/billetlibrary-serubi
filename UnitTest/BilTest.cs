using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;

namespace UnitTest
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void TestBilName()
        {
            // Arrange
            Bil bil = new Bil("1234", DateTime.Now);

            // Act
            string name = bil.Køretøj();

            // Assert
            Assert.AreEqual("Bil", name);
        }

        [TestMethod]
        public void TestBilPrice()
        {
            // Arrange
            Bil bil = new Bil("1234", DateTime.Now);

            // Act
            decimal price = bil.Pris();

            // Assert
            Assert.AreEqual(240, price);
        }


        [TestMethod]
        public void TestNummerpladeLengthException()
        {
            // Arrange

            // Act

            // Assert
            Assert.ThrowsException<Exception>(() => new Bil("12345678", DateTime.Now));
        }

        [TestMethod]
        public void TestBilPriceBrobizz()
        {
            // Arrange
            Bil bil = new Bil("1234", DateTime.Now, true);

            // Act
            decimal price = bil.Pris();

            // Assert
            Assert.AreEqual(228, price);
        }
    }
}
