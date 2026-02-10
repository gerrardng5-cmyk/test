using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gruberoo_prg2_final
{
    internal class OrderFoodItem
    {
        public class OrderedFoodItem : FoodItem
        {
            private int qtyOrdered;
            private double subTotal;

            public OrderedFoodItem(string name, string desc, double price, int qty)
            : base(name, desc, price) // This sends data to FoodItem and fixes your red line!
            {
                this.qtyOrdered = qty;
                this.subTotal = CalculateSubtotal(); // Automatically calculate on creation
            }

            public int QtyOrdered
            {
                get { return qtyOrdered; }
                set { qtyOrdered = value; }
            }

            public double SubTotal
            {
                get { return subTotal; }
            }

            public double CalculateSubtotal()
            {
                this.subTotal = this.ItemPrice * this.qtyOrdered;
                return this.subTotal;
            }
        }
    }
}
