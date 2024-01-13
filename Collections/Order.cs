using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
     public class Order
    {
        public int OrderID { get; set; }
        public int OrderQuantity { get; set; }

        public Order()
        {

        }
        public Order(int id, int orderQuantity)
        {
            this.OrderID = id;
            this.OrderQuantity = orderQuantity;
        }
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderID} has been processed");
        }
    }
}
