using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Products
{
    public class PurchaseMenu
    { //when option (2) selected from MainMenu
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("1) Feed Money");
            Console.WriteLine("2) Select Product");
            Console.WriteLine("3) Finish Transaction");
            Console.WriteLine("/n");
            Console.WriteLine("/n");
            Console.WriteLine("Current Money Provided {:c}");
            Console.Write("Please enter selection: ");
        }
    }
}
