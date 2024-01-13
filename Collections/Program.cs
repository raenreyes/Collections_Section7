using System.Collections;
using System.Threading.Channels;
using System.Formats.Asn1;
using System;
using System.Collections.Generic;


namespace Collections
{
    public class Program
    {
        //Key - Value
        //Auto - Car
        static void Main(string[] args)
        {
            
            Queue<Order> ordersQueue = new Queue<Order>();
            
            foreach (Order i in ReceiveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(i);
            }
            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while(ordersQueue.Count > 0)
            {
                ordersQueue.Dequeue().ProcessOrder();
            }

        }
        public static List<Order> ReceiveOrdersFromBranch1()
        {
            List<Order> orders = new List<Order>();

            orders.Add(new Order(1, 5));
            orders.Add(new Order(2, 4));
            orders.Add(new Order(6, 10));

            return orders;
        }

        public static List<Order> ReceiveOrdersFromBranch2()
        {
            List<Order> orders = new List<Order>();

            orders.Add(new Order(3, 69));
            orders.Add(new Order(4, 4));
            orders.Add(new Order(5, 14));

            return orders;
        }
       


    }


}



