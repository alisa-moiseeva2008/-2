using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double y = double.Parse(Console.ReadLine());
        double arithmeticMean = (x + y) / 2;
        double geometricMean = Math.Pow(x * y, 1.0 / 2.0);
        Console.WriteLine($"Среднее арифметическое: {arithmeticMean}");
        Console.WriteLine($"Среднее геометрическое: {geometricMean}");
        Console.ReadKey();
    }
}
