using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gruberoo_prg2_final
{
    internal class Menu
    {
        public string MenuId { get; set; }
        public string MenuName { get; set; }

        private List<FoodItem> foodItems = new List<FoodItem>();

        public void AddFoodItem(FoodItem item)
        {
            foodItems.Add(item);
        }

        public bool RemoveFoodItem(FoodItem item)
        {
            return foodItems.Remove(item);
        }
        public void DisplayFoodItems()
        {
            // This will now work correctly if FoodItem has the ToString override
            foreach (var item in foodItems)
            {
                Console.WriteLine(item.ToString());
            }
        }

        //public void DisplayFoodItems()
        //{
        //    Console.WriteLine($"Menu: {MenuName}");
        //    foreach (var item in foodItems)
        //    {
        //        Console.WriteLine(item.ToString());
        //    }
        //}

        public override string ToString()
        {
            return $"{MenuName} ({MenuId})";
        }

        public Menu()
        {
            foodItems = new List<FoodItem>();
        }
    }
}