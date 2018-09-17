using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBilName()
        {
            // Arrange
            Bil bil = new Bil();

            // Act
            string name = bil.Køretøj();

            // Assert
            Assert.AreEqual("Bil", name);
        }

        [TestMethod]
        public void TestBilPrice()
        {
            // Arrange
            Bil bil = new Bil();

            // Act
            decimal price = bil.Pris();

            // Assert
            Assert.AreEqual(240, price);
        }
    }
}
