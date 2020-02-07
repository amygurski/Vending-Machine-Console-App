using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone;


namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTests
    {
        [TestMethod]
        public void FillSlotsTests()
        {
            //Arrange
            VendingMachine vm = new VendingMachine();

            //Act
            vm.FillSlots(new string[] {"A1|Potato Crisps|3.05|Chip" });

            //Assert
            Assert.AreEqual(true, vm.Inventory.ContainsKey("A1"));
            Assert.AreEqual(false, vm.Inventory.ContainsKey("E3"));
        }

        [TestMethod]
        public void FeedMoneyTests()
        {
            //Arrange
            VendingMachine vm = new VendingMachine();

            //Act
            vm.FeedMoney(5);

            //Assert
            Assert.AreEqual(5.00M, vm.Balance);

        }

        // find a way to test DispenseItem()?

    }
}