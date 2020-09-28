using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave_1.Tests
{
    [TestClass()]
    public class CykelTests
    {
        [TestMethod()]
        public void TestTooLowValues()
        {
            //Arrange

            Cykel aCykel = new Cykel();

            // Act 

            aCykel.Id = 1;

            // Assert

            Assert.ThrowsException<ArgumentException>(()=>aCykel.Color = "");
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>aCykel.Price = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>aCykel.Gear = 0);

        }

        [TestMethod()]
        public void TestTooHighValues()
        {
            //Arrange

            Cykel aCykel = new Cykel();

            // Act 

            aCykel.Id = 1;

            // Assert

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => aCykel.Gear = 50);

        }

        [TestMethod()]
        public void TestCorrectValues()
        {
            //Arrange

            Cykel aCykel = new Cykel();

            // Act 

            aCykel.Id = 1;

            // Assert

            aCykel.Color = "red";
            aCykel.Price = 100;
            aCykel.Gear = 7;

        }
    }
}