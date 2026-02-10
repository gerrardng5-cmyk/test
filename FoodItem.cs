using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gruberoo_prg2_final
{
    internal class FoodItem
    {
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public double ItemPrice { get; set; }
        public string Customise { get; set; }

        public FoodItem(string ItemName, string ItemDesc, double ItemPrice)
        {
            this.ItemName = ItemName;
            this.ItemDesc = ItemDesc;
            this.ItemPrice = ItemPrice;
        }
        public override string ToString()
        {
            // This format matches Figure 5 exactly
            return $"  - {ItemName}: {ItemDesc} - {ItemPrice:C}";
        }
    }
}
