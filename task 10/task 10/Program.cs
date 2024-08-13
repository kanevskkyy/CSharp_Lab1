using System.Collections.Generic;

class Task
{
    static void Main()
    {
        int number, last_digit;
        Console.Write("Enter your number = ");
        number = int.Parse(Console.ReadLine());
        last_digit = number % 10;
        Console.WriteLine($"Last number = {last_digit}");
    }
}