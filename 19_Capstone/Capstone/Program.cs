using System;
using System.IO;

namespace Capstone
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();
            vm.FillSlots();

        }
    }
}
