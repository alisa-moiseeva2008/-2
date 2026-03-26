using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double n2 = double.Parse(Console.ReadLine());
        double abs1 = Math.Abs(n1);
        double abs2 = Math.Abs(n2);
        double arithmeticMean = (abs1 + abs2) / 2;
        double geometricMean = Math.Sqrt(abs1 * abs2);
        Console.WriteLine($"Модули чисел: {abs1} и {abs2}");
        Console.WriteLine($"Среднее арифметическое модулей: {arithmeticMean}");
        Console.WriteLine($"Среднее геометрическое модулей: {geometricMean}");
        Console.ReadKey();
    }
}
