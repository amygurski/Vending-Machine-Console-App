using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    /// <summary>
    /// Purchase menu is a Main menu which guides the user through the purchase process flow
    /// of adding money, selecting their option(s), and finishing the transaction.
    /// </summary>
    public class PurchaseMenu : MainMenu
    {
        #region Constructor
        public PurchaseMenu(VendingMachine vm) : base(vm) 
        { 
        }
        #endregion

        #region Methods
        public void DisplayPurchaseMenu()
        {
            string input;
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("1) Feed Money"); // allow user to input whole dollar amount repeatedly
                Console.WriteLine("2) Select Product"); //Display items & allow user to select using sortId
                Console.WriteLine("3) Finish Transaction");
                Console.WriteLine("\n");

                Console.WriteLine($"Current Money Provided: {VM.Balance:c}");
                Console.Write("Please enter selection: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        int money = GetUsersPayment();
                        VM.FeedMoney(money);
                        continue;
                    case "2":
                        Dictionary<string, VendingMachineItem> items = VM.Inventory;
                        DisplayItems(items);
                        Console.Write("Please select item: ");
                        string selection = Console.ReadLine().ToUpper();

                        VM.DispenseItem(selection);
                        DisplayDispenseMessage(selection, items);
                        break;
                    case "3":
                        MoneyChanger change = new MoneyChanger(VM.Balance);
                        PrintChange(change);
                        VM.Balance = 0;
                        keepGoing = false;
                        //TODO: Return to Main Menu?
                        break;
                    default:
                        continue;
                }

                Console.ReadLine();
            }

            MainMenu m = new MainMenu(VM);
            m.DisplayMainMenu();

        }

        //TODO: Check that item selection is valid.
        //public void CheckSelection(string selection, Dictionary <string, VendingMachineItem> items)
        //{
        //    if (!items.ContainsKey(selection))
        //    {
        //        Console.WriteLine("Sorry! Invalid Selection. Please try again.");
        //    }

        //    if (items[selection].Quantity < 1)
        //    {
        //        Console.WriteLine("Sorry! Out of stock. Please try again.");
        //    }
        //}

        //TODO: How to pass in ONLY the single dictionary value items[selection]?
        public void DisplayDispenseMessage(string selection, Dictionary<string, VendingMachineItem> items)
        {
            Console.Clear();
            //Balance -= items[selection].Price;
            Console.WriteLine($"{items[selection].ProductName} is yours for only {items[selection].Price:C}.");
            Console.WriteLine($"{items[selection].PurchaseMessage}");
            Console.WriteLine($"You have {VM.Balance:C} remaining - can we tempt you with anything else?");
            Console.WriteLine($"Press Enter to Return to Menu.");
        }

        
        public int GetUsersPayment()
        {
            Console.Write("Please deposit money from your bank (whole dollar only): ");
            string input = Console.ReadLine();

            //TODO: Move feed money - whole dollars - to exception handling
            //TODO: Add exceptions to Feed Money for negative numbers and maybe a maximum value (sum of price of items?). 
            if (!int.TryParse(input, out int value))
            {
                Console.WriteLine("Feed error. Whole Dollar amount required. Please retry.");
            }

            Console.WriteLine($"{value:C} added.");

            return value;
        }

        public void PrintChange(MoneyChanger change)
        {
            Console.WriteLine($"Here is your change: {change.Quarters} Quarters, {change.Dimes} Dimes, {change.Nickels} Nickels, and {change.Pennies} Pennies");
        }
        #endregion
    }
}