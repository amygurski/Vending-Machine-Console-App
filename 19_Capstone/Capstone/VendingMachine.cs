using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        Stocker stocker = new Stocker();
        private Dictionary<string, VendingMachineItem> inventory = new Dictionary<string, VendingMachineItem>();

        public void FillSlots()
        {
            string[] stockList = stocker.GetStock();
            foreach (string item in stockList)
            {
                string[] line = item.Split("|");
                inventory.Add(line[0], new VendingMachineItem(line[1], decimal.Parse(line[2]), line[3]));
            }
        }

        public void DisplayItems()
        {
            foreach (KeyValuePair<string,VendingMachineItem> kvp in inventory)
            {

            }
        }

    }

}
