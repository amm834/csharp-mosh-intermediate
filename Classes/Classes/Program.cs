using System;

namespace Classes
{
    class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hello {0}, I'm {1}", to, Name);
        }

        public static Person Parse(string name)
        {
            var person = new Person();
            person.Name = name;
            return person;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = Person.Parse("Aung Aung");
            person.Introduce("Mg Mg");
        }
    }
}