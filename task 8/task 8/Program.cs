class Task
{
    static void Main()
    {
        float first, second, third, average;
        Console.Write("Enter first number = ");
        first = float.Parse(Console.ReadLine());

        Console.Write("Enter second number = ");
        second = float.Parse(Console.ReadLine());

        Console.Write("Enter third number = ");
        third = float.Parse(Console.ReadLine());

        average = (first + second + third) / 3 ;
        Console.WriteLine($"Average = {average}");
    }
}