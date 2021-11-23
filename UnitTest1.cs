using Microsoft.VisualStudio.TestTools.UnitTesting;
using P4;
using System;

namespace OnlineRetailerUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShippingChargeTest1()
        {
            //Arrange 
            double expectedCharge = 37.5;
            double actualCharge;
            int itemsTest = 10;

            //Act 
            OnlineRetailer online = new OnlineRetailer(itemsTest);
            actualCharge = online.ShippingCharge(itemsTest);

            //Assert 
            Assert.IsTrue(actualCharge == expectedCharge, "Shipping charge incorrectly calculated");
        }

        [TestMethod]
        public void ShippingChargeTest2()
        {
            //Arrange 
            double expectedCharge = 52.25;
            double actualCharge;
            int itemsTest = 15;

            //Act 
            OnlineRetailer online = new OnlineRetailer(itemsTest);
            actualCharge = online.ShippingCharge(itemsTest);

            //Assert 
            Assert.IsTrue(actualCharge == expectedCharge, "Shipping charge incorrectly calculated");
        }

        [TestMethod]
        public void ShippingChargeTest3()
        {
            //Arrange 
            double expectedCharge = 140.75;
            double actualCharge;
            int itemsTest = 45;

            //Act 
            OnlineRetailer online = new OnlineRetailer(itemsTest);
            actualCharge = online.ShippingCharge(itemsTest);

            //Assert 
            Assert.IsTrue(actualCharge == expectedCharge, "Shipping charge incorrectly calculated");
        }
    }
}
