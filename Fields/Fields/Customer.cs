using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();


        public Customer()
        {
        }

        public Customer(int id)
        {
            Id = id;
        }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public void Promote()
        {
        }
    }
}