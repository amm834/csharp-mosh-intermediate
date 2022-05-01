using System;

namespace Fields
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }
    }
}