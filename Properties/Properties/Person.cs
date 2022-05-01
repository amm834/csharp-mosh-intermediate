using System;

namespace Properties
{
    public class Person
    {
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public DateTime BirthDate { get; private set; }

        public int Age
        {
            get
            {
                var timespan = DateTime.Now - BirthDate;
                return timespan.Days / 365;
            }
        }
    }
}