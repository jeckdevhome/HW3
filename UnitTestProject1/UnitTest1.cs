using System;
using HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
     
        [TestMethod]
        public void TestMethodAdd()
        {
            var _calc = new Calc();
            var num1 = 5;
            var num2 = 23;
            var expect = num1 + num2;
            var result = _calc.Add(num1, num2);
            Assert.AreEqual(expect, result);

        }
        [TestMethod]
        public void TestMethodExtract()
        {
            var _calc = new Calc();
            var num1 = 5;
            var num2 = 23;
            var expect = num1 - num2;
            var result = _calc.Extract(num1, num2);
            Assert.AreEqual(expect, result);

        }
        [TestMethod]
        public void TestMethodMyltiply()
        {
            var _calc = new Calc();
            var num1 = 5;
            var num2 = 23;
            var expect = num1 * num2;
            var result = _calc.Multiplay(num1, num2);
            Assert.AreEqual(expect, result);

        }
    }
}
