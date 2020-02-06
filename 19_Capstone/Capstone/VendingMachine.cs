using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        Stocker stocker = new Stocker();

        public Dictionary<string, VendingMachineItem> Inventory { get; } = new Dictionary<string, VendingMachineItem>();

        public void FillSlots()
        {
            string[] stockList = stocker.GetStock();
            foreach (string line in stockList)
            {
                string[] item = line.Split("|");
                Inventory.Add(item[0], new VendingMachineItem(item[1], decimal.Parse(item[2]), item[3]));
            }
        }

        //public Dictionary<string, VendingMachineItem> GetItems()
        //{

        //}

    }

}
