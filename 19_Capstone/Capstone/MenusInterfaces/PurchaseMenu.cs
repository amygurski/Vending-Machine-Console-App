using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class PurchaseMenu
    {
        public decimal Balance { get; set; }
        public VendingMachine VM { get; set; }

        public PurchaseMenu (VendingMachine vm)
        {
        this.VM = vm;
        }

        public void DisplayPurchaseMenu()
        {
            string input;
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("1) Feed Money"); // allow user to input whole dollar amount repeatedly
                Console.WriteLine("2) Select Product"); //DisplayItems & allow user to select using sortId
                Console.WriteLine("3) Finish Transaction");
                Console.WriteLine("\n");
                Console.WriteLine($"Current Money Provided: {Balance:c}");
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
                        Console.Write("Please select item: ");
                        string selection = Console.ReadLine().ToUpper();
                        CheckSelection(selection, items);
                        DispenseItem(selection, items);
                        break;
                    case "1":
                        FeedMoney();
                        continue;
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

        public void CheckSelection(string selection, Dictionary <string, VendingMachineItem> items)
        {
            if (!items.ContainsKey(selection))
            {
                Console.WriteLine("Sorry! Invalid Selection. Please try again.");
            }
            
            if (items[selection].Quantity < 1)
            {
                Console.WriteLine("Sorry! Out of stock. Please try again.");
            }
        }

        public void DispenseItem(string selection, Dictionary<string, VendingMachineItem> items)
        {
            Console.Clear();
            Balance -= items[selection].Price;
            Console.WriteLine($"{items[selection].ProductName} is yours for only {items[selection].Price}.");
            Console.WriteLine($"{items[selection].PurchaseMessage}");
            Console.WriteLine($"You have {Balance} remaining - can we tempt you with anything else?");
        }

        public void FeedMoney()
        {
            Console.Write("Please deposit money from your bank (whole dollar only): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int value))
            {
                Console.WriteLine("Feed error. Whole Dollar amount required. Please retry.");
            }

            Balance += value;
        }
    }

}

