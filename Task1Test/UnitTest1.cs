using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1.Test
{
    [TestClass]
    public class NewtonMethodTest
    {


        [TestMethod]
        public void CompareWithMathPowTest()
        {
            Assert.AreEqual(NewtonMethod.FindingTheRoot(64, 3, 0.0001), Math.Pow(64, 1.0 / 3), 0.0001);
        }

        [TestMethod]
        public void NumberIsNanTest()
        {
            Assert.AreEqual(NewtonMethod.FindingTheRoot(-17, 4, 0.0001), double.NaN);
        }

        [TestMethod]
        public void ExponentIsOneTest()
        {
            Assert.AreEqual(NewtonMethod.FindingTheRoot(121, 0, 0.0001), 1);
        }

        [TestMethod]
        public void NumberIsZero()
        {
            Assert.AreEqual(NewtonMethod.FindingTheRoot(0, 7, 0.0001), 0);
        }
    }
}

