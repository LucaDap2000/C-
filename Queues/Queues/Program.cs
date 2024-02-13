using System;
using System.Collections.Generic;
namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining a queue of integers
            Queue<int> queue = new Queue<int>();

            // Printing the element at the front of the queue

            queue.Enqueue(1);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(3);

            // Dequeue() removes and stores the item at the front of the queue
            int queueItem = queue.Dequeue();

            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());

            while (queue.Count > 0)
            {
                // Dequeue will return the element that was removed from the queue
                Console.WriteLine("The value removed from the front of the queue was: {0}", queue.Dequeue());

                // Print the queue count
                Console.WriteLine("The current queue count is: {0}", queue.Count);
            }

            // Create a queue of orders

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                // Add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                // Add each order to the queue
                ordersQueue.Enqueue(o);
            }

            // As long as the queue is not empty
            while (ordersQueue.Count > 0)
            {
                // Remove the order at the front of the queue
                // and store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                // Process the order
                currentOrder.ProcessOrder();
            }
        }

        // This method will create an array of orders and return it
        static Order[] ReceiveOrdersFromBranch1()
        {
            // Creating new orders array
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10),
            };
            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {
            // Creating new orders array and initialising it with some objects of type Order
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10),
            };
            // Return the array of orders that we created
            return orders;
        }
    }

    // A class named order, we will use it to store instances of it inside a queue 

    class Order
    {
        // Order ID
        public int OrderID { get; set; }

        // Quantity of the order
        public int OrderQuantity { get; set; }

        // Simple constructor
        public Order(int id, int orderquantity)
        {
            this.OrderID = id;
            this.OrderQuantity = orderquantity;
        }

        // Print message on the screen that the order was processed
        public void ProcessOrder()
        {
            // Print the message
            Console.WriteLine($"Order {OrderID} processed!");
        }
    }
}
