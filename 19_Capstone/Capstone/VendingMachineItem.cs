using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachineItem
    {
        #region Properties
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public string PurchaseMessage
        {
            get
            {
                switch(Type)
                {
                    case "Chip":
                        return "Crunch, Crunch, Yum!";
                    case "Beverage":
                        return "Glug, Glug, Yum!";
                    case "Candy":
                        return "Munch, Munch, Yum!";
                    case "Gum":
                        return "Chew, Chew, Yum!";
                    default:
                        return "Yum Yum!";
                }
            }
        }
        #endregion

        #region Constructors
        public VendingMachineItem(string name, decimal price, string type)
        {
            this.ProductName = name;
            this.Price = price;
            this.Type = type;
            this.Quantity = 5;
        }
        #endregion

        #region Methods
        public int UpdateQuantity()
        {
            return 5;
        }

        #endregion
    }
}
