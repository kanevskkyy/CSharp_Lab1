using System;

class Task
{
    static void Main()
    {
        int counter = 0;
        float first, second, third;
        string sign;
        Console.Write("Enter first number = ");
        first = float.Parse(Console.ReadLine());

        if (first < 0) counter++;

        Console.Write("Enter second number = ");
        second = float.Parse(Console.ReadLine());

        if (second < 0) counter++;

        Console.Write("Enter third number = ");
        third = float.Parse(Console.ReadLine());

        if (third < 0) counter++;

        if (counter == 1 || counter == 3)
        {
            sign = "Negative";
            Console.WriteLine(sign);
        }
        else
        {
            sign = "Positive";
            Console.WriteLine(sign);
        }
    }
}
