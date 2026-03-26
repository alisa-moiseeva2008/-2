using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите внешний радиус R: ");
        double R = double.Parse(Console.ReadLine());
        Console.Write("Введите внутренний радиус r: ");
        double r = double.Parse(Console.ReadLine());
        double S = Math.PI * (R * R - r * r);
        Console.WriteLine($"Площадь кольца = {S}");
        Console.ReadKey();
    }
}
