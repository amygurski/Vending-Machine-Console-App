using System;
using System.Collections.Generic;
using System.Text;


namespace Capstone
{
    public class MainMenu
    {
        
        public VendingMachine VM { get; set; }


        public MainMenu(VendingMachine vm)
        {
            this.VM = vm;
        }
        public void DisplayMainMenu()

        {
            string input;
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("1) Display Vending Machine Items");
                Console.WriteLine("2) Purchase"); // go to PurchaseMenu
                Console.WriteLine("3) Exit");
                Console.Write("Please enter selection: ");
                input = Console.ReadLine();


                switch (input)
                {
                    case "3":
                        keepGoing = false;
                        continue;
                    case "1":
                        Dictionary<string, VendingMachineItem> items = VM.Inventory;
                        DisplayItems(items);
                        break;
                    case "2":
                        PurchaseMenu pm = new PurchaseMenu(VM);
                        pm.DisplayPurchaseMenu();
                        break;
                    case "4":
                        SalesReporter.Report(VM.Inventory);
                        Console.WriteLine($"A sales report has been generated");
                        break;
                    default:
                        continue;
                }

                Console.ReadLine();
            }
        }

        public void DisplayItems(Dictionary<string, VendingMachineItem> items)
        {

            foreach (KeyValuePair<string, VendingMachineItem> kvp in items)
            {
                Console.WriteLine($"Slot: {kvp.Key} Name: {kvp.Value.ProductName} Price: {kvp.Value.Price} Remaining: {kvp.Value.Quantity} Type: {kvp.Value.Type}");
            }
        }
    }

}


