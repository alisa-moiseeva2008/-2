using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Решение уравнения ax + b = 0 (a ≠ 0)");
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());
        if (a != 0)
        {
            double x = -b / a;
            Console.WriteLine($"x = {x}");
        }
        else
        {
            Console.WriteLine("a не должно быть равно 0");
        }
        Console.ReadKey();
    }
}
