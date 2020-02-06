using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Products
{
    public class MainMenu
    {

        public static void Main(string[] args)

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
                        DisplayItems();
                        break;
                    case "2":
                        GoToPurchaseMenu();
                        break;
                    default:
                        continue;
                }
                public static void DisplayItems();

    }
        }
    }

}


