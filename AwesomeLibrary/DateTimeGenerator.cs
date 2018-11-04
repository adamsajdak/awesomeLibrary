using System;

namespace AwesomeLibrary
{
    public class DateTimeGenerator
    {
        public string Generate(bool isLongDate)
        {
            var n = 9999999999;
            for (var i = 0; i < n; i++)
            {
                var x = 1;

                var j = x + i;
            }
            if(isLongDate)
            {
                return DateTime.Now.ToLongDateString();
            }
            return DateTime.Now.ToShortDateString();
        }
    }
}
