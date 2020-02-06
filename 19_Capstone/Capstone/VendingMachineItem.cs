using Capstone.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    abstract public class VendingMachineItem
    {
        #region Properties
        string ProductName { get; set; }
        decimal Price { get; set; }
        string SlotId { get; set; }
        int Quantity { get; set; }
        string Type { get; set; }
        #endregion

        #region Constructors
        public VendingMachineItem(string slotId, string name, decimal price, string type)
        {
            this.ProductName = name;
            this.SlotId = slotId;
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

        abstract public string PurchaseMessage();

        #endregion
    }
}
