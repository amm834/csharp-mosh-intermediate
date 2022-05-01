using System;

namespace Properties
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person(new DateTime(2000, 1, 2));
            Console.WriteLine(person.Age);
        }
    }
}