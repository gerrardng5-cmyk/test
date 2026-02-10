using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gruberoo_prg2_final
{
    internal class Order
    {
        private int OrderID;
        private DateTime OrderDateTime;
        private double OrderTotal;
        private string OrderStatus;
        private string DeliveryAddress;
        private string OrderPaymentMethod;
        private bool OrderPaid;
        public int orderID
        {
            get { return this.OrderID; }
            set { this.OrderID = value; }
        }
        public DateTime orderDateTime
        {
            get { return this.OrderDateTime; }
            set { this.OrderDateTime = value; }
        }
        public double orderTotal
        {
            get { return this.OrderTotal; }
            set { this.OrderTotal = value; }
        }
        public string orderStatus
        {
            get { return this.OrderStatus; }
            set { this.OrderStatus = value; }
        }
        public string deliveryAddress
        {
            get { return this.deliveryAddress; }
            set { this.deliveryAddress = value; }
        }
        public string orderPaymentMethod
        {
            get { return this.orderPaymentMethod; }
            set { this.orderPaymentMethod = value; }
        }
        public bool orderPaid
        {
            get { return this.orderPaid; }
            set { this.orderPaid = value; }
        }
        private List<object> _orderedFoodItems = new List<object>();

        // Public Methods
        public double CalculateOrderTotal()
        {
            // Logic to sum up prices of items
            return orderTotal;
        }

        public void AddOrderedFoodItem(object orderedFoodItem)
        {
            _orderedFoodItems.Add(orderedFoodItem);
        }

        public bool RemoveOrderedFoodItem(object orderedFoodItem)
        {
            return _orderedFoodItems.Remove(orderedFoodItem);
        }

        public void DisplayOrderedFoodItems()
        {
            foreach (var item in _orderedFoodItems)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public Customer CustomerName { get; set; }
        public Restaurant RestaurantName { get; set; }

        public override string ToString()
        {
            return $"Order ID: {orderID}, OrderDate: {OrderDateTime}, Status: {orderStatus}, Total: {orderTotal}";
        }
    }
}
