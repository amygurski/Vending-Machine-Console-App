using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    /// <summary>
    /// Main Menu shows the user the available items and directs them to the purchase sub-menu or to exit
    /// </summary>
    public class MainMenu
    {
        public VendingMachine VM { get; }

        public MainMenu(VendingMachine vm)
        {
            this.VM = vm;
        }
        public void DisplayMainMenu()

        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                DisplayLogo();
                Console.WriteLine("1) Display Vending Machine Items");
                Console.WriteLine("2) Purchase"); // go to PurchaseMenu
                Console.WriteLine("3) Exit");
                Console.Write("Please enter selection: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Dictionary<string, VendingMachineItem> items = VM.Inventory;
                        DisplayItems(items);
                        Console.WriteLine("\nPress Enter to Return to Main Menu selection.");
                        break;
                    case "2":
                        PurchaseMenu pm = new PurchaseMenu(VM);
                        pm.DisplayPurchaseMenu();
                        break;
                    case "3":
                        keepGoing = false;
                        break;
                    default:
                        continue;
                }
                Console.ReadLine();
            }
        }

        public void DisplayItems(Dictionary<string, VendingMachineItem> items)
        {
            Console.WriteLine("\n  ------------------------------------------------");
            Console.WriteLine("  |{0, 0} | {1,-20} | {2,5} | {3,8} |", "ID", "Item", "Price", "Remaining");
            Console.WriteLine("  ------------------------------------------------");
            foreach (KeyValuePair<string, VendingMachineItem> kvp in items)
            {
                Console.WriteLine($"  |{kvp.Key, 0} | {kvp.Value.ProductName, -20} | {kvp.Value.Price, 5} | {kvp.Value.Quantity, 5}     |");
            }
            Console.WriteLine("  ------------------------------------------------");
        }

        public void DisplayLogo()
        {
            //TODO: Add nice header for Vendo-Matic 800
            //Used http://patorjk.com/software/taag/ previously
        }
    }

}


