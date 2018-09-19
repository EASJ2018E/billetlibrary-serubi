using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
	[TestClass]
	public class MCTest
	{

		[TestMethod]
		public void TestMCName()
		{
			// Arrange
			Motorcykel mc = new Motorcykel("1234", DateTime.Now);

			// Act
			string name = mc.Køretøj();

			// Assert
			Assert.AreEqual("MC", name);
		}

		[TestMethod]
		public void TestMCPrice()
		{
			// Arrange
			Motorcykel mc = new Motorcykel("1234", DateTime.Now);

			// Act
			decimal price = mc.Pris();

			// Assert
			Assert.AreEqual(125, price);
		}
	}
}
