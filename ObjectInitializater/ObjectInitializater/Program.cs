using System;

namespace ObjectInitializater
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Mg Mg",
                Age = 19
            };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}