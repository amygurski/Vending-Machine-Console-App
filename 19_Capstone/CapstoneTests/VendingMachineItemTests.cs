using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineItemTests
    {
        [TestMethod]
        public void UpdateQuantityTest()

        {
            VendingMachineItem item = new VendingMachineItem("Potato Crisps", 3.05M, "Chip");
            int initialQuantity = item.Quantity; //Currently 5

            item.UpdateQuantity();
            Assert.AreEqual(initialQuantity-1, item.Quantity);

            item.UpdateQuantity();
            Assert.AreEqual(initialQuantity-2, item.Quantity);
        }

    }
}