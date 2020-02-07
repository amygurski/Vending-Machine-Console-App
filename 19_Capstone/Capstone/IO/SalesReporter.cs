using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Capstone;

namespace Capstone
{
    public static class SalesReporter
    {
        public static void Report(Dictionary<string, VendingMachineItem> inventory)
        {
            decimal totalSales = 0m;
            // start with current directory
            string currentDirectory = Directory.GetCurrentDirectory();
            // find target directory
            string targetDirectory = currentDirectory.Remove(currentDirectory.IndexOf("19_Capstone") + 11);
            // add file name to path
            using (StreamWriter sw = new StreamWriter(targetDirectory + $"\\{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}_SalesReport.txt"))
            {
                foreach (KeyValuePair<string, VendingMachineItem> inventoryItem in inventory)
                {
                    totalSales += inventoryItem.Value.Price * (5 - inventoryItem.Value.Quantity);
                    sw.WriteLine($"{inventoryItem.Value.ProductName}|{5 - inventoryItem.Value.Quantity}");
                }
                sw.WriteLine();
                sw.WriteLine($"Total Sales :{totalSales:C}");
            }
        }
    }
}