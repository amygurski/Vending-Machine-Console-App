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

        public string PurchaseMessage()
        {
            return "";
        }

        #endregion
    }
}
