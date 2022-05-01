using System;

namespace AccessModifiers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.SetDateTime(new DateTime(2022, 5, 1));
            Console.WriteLine(person.GetDateTime());
        }
    }
}