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

        [TestMethod]
        public void DispenseItemsTests()
        {
            //Arrange
            VendingMachine vm = new VendingMachine();

            //Act
            vm.FillSlots(new string[] { "A1|Potato Crisps|3.05|Chip" });
            vm.DispenseItem("A1"); 

            //Assert
            Assert.AreEqual(4, vm.Inventory["A1"].Quantity);
            Assert.AreEqual(3.05M, vm.Inventory["A1"].Price);
            Assert.AreEqual(-3.05M, vm.Balance);
        }

        [TestMethod]
        public void MakeChangeTests()
        {
            //Arrange
            VendingMachine vm = new VendingMachine();

            //Act
            vm.MakeChange();

            //Assert
            Assert.AreEqual(0, vm.Balance);
        }

    }
}