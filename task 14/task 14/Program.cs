using System;

class Task
{
    static void Main()
    {
        int first, second, third;

        Console.Write("Enter first number = ");
        first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number = ");
        second = int.Parse(Console.ReadLine());

        Console.Write("Enter third number = ");
        third = int.Parse(Console.ReadLine());


        if (first > second && first > third) Console.WriteLine($"Number {first} is the biggest");
        else if (second > first && second > third) Console.WriteLine($"Number {second} is the biggest");
        else Console.WriteLine($"Number {third} is the biggest");
    }
}
