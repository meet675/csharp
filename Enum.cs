using System;

public class Program
{
    // Define an enum for days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public static void Main(string[] args)
    {
        // Assign a value from the enum
        DaysOfWeek today = DaysOfWeek.Wednesday;

        // Switch statement to check the day
        switch (today)
        {
            case DaysOfWeek.Sunday:
                Console.WriteLine("Today is Sunday.");
                break;
            case DaysOfWeek.Monday:
                Console.WriteLine("Today is Monday.");
                break;
            case DaysOfWeek.Tuesday:
                Console.WriteLine("Today is Tuesday.");
                break;
            case DaysOfWeek.Wednesday:
                Console.WriteLine("Today is Wednesday.");
                break;
            case DaysOfWeek.Thursday:
                Console.WriteLine("Today is Thursday.");
                break;
            case DaysOfWeek.Friday:
                Console.WriteLine("Today is Friday.");
                break;
            case DaysOfWeek.Saturday:
                Console.WriteLine("Today is Saturday.");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    }
}