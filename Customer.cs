using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gruberoo_prg2_final
{
    internal class Restaurant
    {
        private string RestaurantID;
        private string RestaurantName;
        private string RestaurantEmail;
        public string restaurantID
        {
            get { return RestaurantID; }
            set { RestaurantID = value; }
        }
        public string restaurantname
        {
            get { return RestaurantName; }
            set { RestaurantName = value; }
        }

        public List<Menu> Menus { get; set; } = new List<Menu>();
        public List<SpecialOffer> SpecialOffers { get; set; } = new List<SpecialOffer>();
        public List<Order> order { get; set; } = new List<Order>();

        public string email
        {
            get { return RestaurantEmail; }
            set { RestaurantEmail = value; }
        }
        //constructor
        public Restaurant(string id, string name, string email)
        {
            RestaurantID = id;
            RestaurantName = name;
            RestaurantEmail = email;
        }
        public void DisplaySpecialOffers()
        {
            foreach (var offer in SpecialOffers)
            {

                Console.WriteLine(offer.offerCode, offer.offerDesc, offer.discount);
            }
        }
        public void DisplayMenu()
        {
            foreach (var menu in Menus)
                menu.DisplayFoodItems();
        }
        public void AddMenu(Menu menu)
        {
            Menus.Add(menu);
        }
        public bool RemoveMenu(Menu menu)
        {
            return Menus.Remove(menu);
        }
        public override string ToString()
        {
            return $"Restaurant ID: {RestaurantID} , Restaurant Name: {RestaurantName}";
        }
    }
}

