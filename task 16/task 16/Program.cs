using System;

class Task
{
    static void Main()
    {
        int day_of_week;
        Console.Write("Enter number of week = ");
        day_of_week = int.Parse(Console.ReadLine());

        switch (day_of_week)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Not valid");
                break;
        }

    }
}