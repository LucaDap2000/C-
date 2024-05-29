using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY__Don_t_Repeat_Yourself_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscountCalculator discountCalculator = new DiscountCalculator();

            double regularCustomerDiscount = discountCalculator.CalculateDiscount(CustomerType.Regular, 1200);
            Console.WriteLine($"Regular Customer Discount: {regularCustomerDiscount}");

            double premiumCustomerDiscount = discountCalculator.CalculateDiscount(CustomerType.Premium, 800);
            Console.WriteLine($"Premium Customer Discount: {premiumCustomerDiscount}");

            double employeeCustomerDiscount = discountCalculator.CalculateDiscount(CustomerType.Employee, 1500);
            Console.WriteLine($"Employee Customer Discount: {employeeCustomerDiscount}");

            /*
            double regularCustomerDiscount = discountCalculator.CalculateDiscountForRegularCustomer(1200);
            Console.WriteLine($"Regular Customer Discount: {regularCustomerDiscount}");

            double premiumCustomerDiscount = discountCalculator.CalculateDiscountForPremiumCustomer(800);
            Console.WriteLine($"Premium Customer Discount: {premiumCustomerDiscount}");

            double employeeCustomerDiscount = discountCalculator.CalculateDiscountForEmployeeCustomer(1500);
            Console.WriteLine($"Employee Customer Discount: {employeeCustomerDiscount}");
            */

            Console.ReadKey();
        }
    }
}
