using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3Test
{
    [TestClass]
    public class HexProviderTest
    {
        [TestMethod]
        public void FormatIntToHexTest()
        {
            HexProvider hexProvider = new HexProvider();
            Assert.AreEqual(string.Format(hexProvider, "{0:H}", -231), "-E7");
            Assert.AreEqual(string.Format(hexProvider, "{0:H}", 10045), "273D");
            Assert.AreEqual(string.Format(hexProvider, "{0:H}", -234456), "-393D8");
        }
    }
}
