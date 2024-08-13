using System;

class Task
{
    static void Main()
    {
        int factorial = 1, n;
        Console.Write("Enter the value of the factor you want to find = ");
        n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Result = {factorial}");
    }
}