using System;

class Task
{
    static void Main()
    {
        int number;
        bool result;
        Console.Write("Enter your number = ");
        number = int.Parse(Console.ReadLine());

        if (number % 9 == 0 || number % 11 == 0 || number % 13 == 0) result = true;
        else result = false;

        Console.WriteLine($"Result = {result}");
    }
}
