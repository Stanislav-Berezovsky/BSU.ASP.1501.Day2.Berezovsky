using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;
using System.Diagnostics;

namespace Task4Test
{
    [TestClass]
    public class NODTest
    {
        [TestMethod]
        public void EuclideanMethodTest()
        {
            long ticks = 0;
            Assert.AreEqual(NOD.EuclideanMethod(1000,-750), 250);
            Assert.AreEqual(NOD.EuclideanMethod(out ticks,1000, -750), 250);
            Debug.WriteLine("EuclideanMethodTime  :{0}", ticks);
            Assert.AreEqual(NOD.EuclideanMethod(1000, -750,800,550), 50);
            Assert.AreEqual(NOD.EuclideanMethod(out ticks, 1000, -750, 800, 550), 50);
            Debug.WriteLine("EuclideanMethodArrayTime  :{0}", ticks);
        }

        [TestMethod]
        public void SteinMethodTest()
        {
            long ticks = 0;
            Assert.AreEqual(NOD.SteinMethod(1000,-750),250);
            Assert.AreEqual(NOD.SteinMethod(out ticks, 1000, -750), 250);
            Debug.WriteLine("EuclideanMethodTime  :{0}", ticks);
            Assert.AreEqual(NOD.SteinMethod(1000, -750, 800, 550), 50);
            Assert.AreEqual(NOD.SteinMethod(out ticks, 1000, -750, 800, 550), 50);
            Debug.WriteLine("EuclideanMethodArrayTime  :{0}", ticks);
        }

    }
    
    
}
