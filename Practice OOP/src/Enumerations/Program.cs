using Enumerations;

string day;
Console.Write("Enter day: "); day = Console.ReadLine();

Enum.TryParse<DaysOfWeek>(day, out DaysOfWeek dayOfWeek);

Console.WriteLine($"{dayOfWeek} is a {DayType.GetDayType(dayOfWeek)}");