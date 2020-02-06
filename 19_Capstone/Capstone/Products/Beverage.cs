using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Products
{
    public class Beverage : VendingMachineItem
    {
        override public string PurchaseMessage()
        {
            return "Glug Glug, Yum";

        }


    }
}
