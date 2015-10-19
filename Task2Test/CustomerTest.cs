using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Task2Test
{
    [TestClass]
    public class CustomerTest
    {
        Customer customer = new Customer("Иван","1112211",678);
        [TestMethod]
        public void FormatTest()
        {
            Assert.AreEqual(string.Format("{0:N}",customer),customer.Name);
            Assert.AreEqual(string.Format("{0:NCR}", customer), string.Format("{0} {1} {2}",customer.Name,customer.ContactPhone,customer.Revenue));
            var cfp = new CustomerFormatProvider();
            Assert.AreEqual(string.Format(cfp,"{0:QQQ}",customer),"навИ");
        }
    }
}
