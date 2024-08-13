using System;

class Task
{
    static void Main()
    {
        int number;
        bool result;
        Console.Write("Enter your number = ");
        number = int.Parse(Console.ReadLine());

        if (number % 2 == 1 && number > 20) result = true;
        else result = false;

        Console.WriteLine($"Result = {result}");
    }
}
