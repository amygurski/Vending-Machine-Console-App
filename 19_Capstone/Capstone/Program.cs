using System;
using System.IO;

namespace Capstone
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stocker stocker = new Stocker();
            string[] stock = stocker.GetStock();

            VendingMachine vm = new VendingMachine();
            vm.FillSlots(stock);

        }
    }
}
