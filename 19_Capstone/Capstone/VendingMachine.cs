using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public Dictionary<string, VendingMachineItem> Inventory { get; } = new Dictionary<string, VendingMachineItem>();

        public void FillSlots(string[] stockList)
        {
            foreach (string line in stockList)
            {
                string[] item = line.Split("|");
                Inventory.Add(item[0], new VendingMachineItem(item[1], decimal.Parse(item[2]), item[3]));
            }
        }
    }
}