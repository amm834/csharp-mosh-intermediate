using System;

namespace Constructor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1, "Mg Mg");
            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Orders.Count);
        }
    }
}