using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _dateTime;

        public void SetDateTime(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        public DateTime GetDateTime()
        {
            return _dateTime;
        }
    }
}