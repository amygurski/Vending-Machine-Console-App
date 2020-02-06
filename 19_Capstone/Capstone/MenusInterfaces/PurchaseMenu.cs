using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{    
    public class PurchaseMenu

    {

    
    public VendingMachine VM { get; set; }

    public PurchaseMenu (VendingMachine vm)
    {
        this.VM = vm;
    }

    public void DisplayPurchaseMenu()
        {
            decimal money = 0.00M;
            string input;
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("1) Feed Money"); // allow user to input whole dollar amount repeatedly
                Console.WriteLine("2) Select Product"); //DisplayItems & allow user to select using sortId
                Console.WriteLine("3) Finish Transaction");
                Console.WriteLine("\n");
                Console.WriteLine("Current Money Provided: {money:c}");
                Console.Write("Please enter selection: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "3":
                        keepGoing = false;
                        continue;
                    case "2":
                        Dictionary<string, VendingMachineItem> items = VM.Inventory;
                        DisplayItems(items);
                        Console.Write("Please enter selection: ");
                        break;
                    case "1":

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

