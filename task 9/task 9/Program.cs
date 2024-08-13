using System.Collections.Generic;

class Task
{
    static void Main()
    {
        float first_side, second_side, height, area;
        Console.Write("Enter the first side of the trapezoid  = ");
        first_side = float.Parse(Console.ReadLine());

        Console.Write("Enter the second side of the trapezoid  = ");
        second_side = float.Parse(Console.ReadLine());

        Console.Write("Enter the height of the trapezoid  = ");
        height = float.Parse(Console.ReadLine());

        area = ((first_side + second_side) / 2) * height;
        Console.WriteLine($"Area = {area}");
    }
}