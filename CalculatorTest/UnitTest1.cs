using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        Khalculator calcT = new Khalculator();

        [TestMethod]
        public void addTest()
        {
            double result = calcT.Addition(10, 15);
            Assert.AreEqual(25.0, result);
        }

        [TestMethod]
        public void subTest()
        {
            double result = calcT.Subtraction(15, 10);
            Assert.AreEqual(5.0, result);
        }

        [TestMethod]
        public void multiTest()
        {
            double result = calcT.Multiplication(10, 5);
            Assert.AreEqual(50.0, result);
        }

        [TestMethod]
        public void divTest()
        {
            double result = calcT.Division(20, 5);
            Assert.AreEqual(4.0, result);
        }

        [TestMethod]
        public void subAddTestRossz()
        {
            double result = calcT.Addition(10, 15);
            Assert.AreNotEqual(26.0, result);
        }

        [TestMethod]
        public void subTestRossz()
        {
            double result = calcT.Subtraction(15, 10);
            Assert.AreNotEqual(6.0, result);
        }

        [TestMethod]
        public void multiTestRossz()
        {
            double result = calcT.Multiplication(10, 5);
            Assert.AreNotEqual(51.0, result);
        }

        [TestMethod]
        public void divTestRossz()
        {
            double result = calcT.Division(20, 5);
            Assert.AreNotEqual(5.0, result);
        }
    }
}
