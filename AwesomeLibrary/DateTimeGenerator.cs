using System;

namespace AwesomeLibrary
{
    public class DateTimeGenerator
    {
        public string Generate(bool isLongDate)
        {
            if(isLongDate)
            {
                return DateTime.Now.ToLongDateString();
            }
            return DateTime.Now.ToShortDateString();
        }
    }
}
