using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine($"{num} --- вот какое число Вы ввели");
        Console.ReadKey();
    }
}
