using System;

class Task
{
    static void Main()
    {
        int number, n, n_digit;
        Console.Write("Enter your number = ");
        number = int.Parse(Console.ReadLine());
        Console.Write("Enter index of number, value you want to know = ");
        n = int.Parse(Console.ReadLine());

        int length = number.ToString().Length;
        if (n < 1 || n > length)
        {
            Console.WriteLine("-");
            return;
        }

        n_digit = (number / (int)Math.Pow(10, length - n)) % 10;

        Console.WriteLine($"Result = {n_digit}");
    }
}
