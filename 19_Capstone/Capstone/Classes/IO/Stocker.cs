using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    /// <summary>
    /// Stocks Vending Machine Inventory from provided file.
    /// The file is expected to be in the current working directory.
    /// </summary>
    public class Stocker
    {
        //TODO: Add error handling if stock file not found
        public string[] GetStock()
        {
            string inputfile = "vendingmachine.csv";
            string[] stock;

            stock = File.ReadAllLines(Environment.CurrentDirectory + "\\" + inputfile);

            return stock;
        }
       
    }
}
