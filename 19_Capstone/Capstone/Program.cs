using System;

namespace Capstone
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();
            vm.FillSlots();
            MainMenu menu = new MainMenu(vm);
            menu.DisplayMainMenu();
        }
    }
}
