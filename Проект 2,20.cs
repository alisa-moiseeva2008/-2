using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите катет a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите катет b: ");
        double b = double.Parse(Console.ReadLine());
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine($"Гипотенуза = {c}");
        Console.ReadKey();
    }
}
