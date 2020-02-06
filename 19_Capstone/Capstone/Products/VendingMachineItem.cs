using Capstone.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public abstract class VendingMachineItem
    {
        string ProductName { get; set; }
        decimal Price { get; set; }
        string slotId { get; set; }
        int quantity { get; set; } = 5;
        string type { get; set; }
        //methods

        public int updateQuantity()
        {
            return 5;
        }

        virtual public string PurchaseMessage() 
        { 
            return ""; 
        
        }
       
        
    }
}
