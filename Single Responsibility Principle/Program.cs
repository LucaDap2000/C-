using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1, ProductName = "Laptop", Quantity = 2, Price = 500};
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
        }
    }
}
