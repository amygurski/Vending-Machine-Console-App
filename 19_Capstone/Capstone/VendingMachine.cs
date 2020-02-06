using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Products;

namespace Capstone
{
    class VendingMachine
    {
        private Dictionary<string, VendingMachineItem> products = new Dictionary<string, VendingMachineItem>();

        public void FillSlots(string[] stock)
        {
            foreach (string item in stock)
            {
                string[] line = item.Split("|");
            }
            //product.Add(arr[0], )
            //Loop through file
            //If type = chip, make a chip object 
            //Chip properties are split string for slotID, Name, and Price
            //Same for Gum, candy, beverage
        }

    }

}
