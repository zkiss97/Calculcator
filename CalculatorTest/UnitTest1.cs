using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addTest()
        {
            var CalcT = new CalculatorTest();
            int result = Calculator.Add(10, 15);
            Assert.AreEqual<int>(25, result);
        }
    }
}
