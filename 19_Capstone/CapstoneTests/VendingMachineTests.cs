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
            vm.FillSlots();

            //Assert
            Assert.AreEqual()

        }
    }
}
