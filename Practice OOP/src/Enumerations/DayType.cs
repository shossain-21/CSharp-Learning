using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public class DayType
    {
        public static string GetDayType(DaysOfWeek day)
        {
            return day switch
            {
                DaysOfWeek.Saturday => "Weekend",
                DaysOfWeek.Sunday => "Weekday",
                DaysOfWeek.Monday => "Weekday",
                DaysOfWeek.Tuesday => "Weekday",
                DaysOfWeek.Wednesday => "Weekday",
                DaysOfWeek.Thursday => "Weekday",
                DaysOfWeek.Friday => "Weekend",
                _ => "Invalid day"
            };
        }
    }
}
