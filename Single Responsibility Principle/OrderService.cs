using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    // In practice you should separate each of these methods out into their own classes i.e., one class to log and another to notify the customer

    internal class OrderService
    {
        private List<Order> orders = new List<Order>();
        private OrderLogger orderLogger = new OrderLogger();
        private OrderNotifier orderNotifier = new OrderNotifier();

        public void AddOrder(Order order)
        {
            orders.Add(order);
            orderLogger.LogOrder(order);
            orderNotifier.NotifyCustomer(order);
        }

        /*
        private void LogOrder(Order order)
        {
            // Log the order to a file
            Console.WriteLine($"Order {order.Id} logged");
        }
        
        private void NotifyCustomer(Order order)
        {
            // Send a notification to the customer
            Console.WriteLine($"Customer notified for order {order.Id}");
        }
        */
    }

    public class OrderLogger
    {
        internal void LogOrder(Order order)
        {
            // Log the order to a file
            Console.WriteLine($"Order {order.Id} logged");
        }
    }

    public class OrderNotifier
    {
        internal void NotifyCustomer(Order order)
        {
            // Send a notification to the customer
            Console.WriteLine($"Customer notified for order {order.Id}");
        }
    }
}
