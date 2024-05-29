using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Code___Method_Structuring
{
    internal class OrderProcessor
    {
        // This may look ok but these should be split up into three different methods
        // One to validate, one to save and one to notify the customer
        public void Order(Order order)
        {
            // Validate order
            if (order.Quantity > 0)
            {
                // Save order
                Console.WriteLine("Order saved");

                // Notify customer
                Console.WriteLine("Customer notified");
            }
        }

        // It should be structured like the following:

        public void ProcessOrder(Order order)
        {
            if (IsValid(order))
            {
                SaveOrder(order);
                NotifyCustomer(order);
            }
        }

        public bool IsValid(Order order)
        {
            // TODO: Validate order logic
            return false;
        }

        private void SaveOrder(Order order)
        {
            // TODO: Save order logic
        }

        private void NotifyCustomer(Order order)
        {
            // TODO: Notify customer logic
        }
    }
}
