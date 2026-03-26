using System;
internal class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Console.Write("Введите начало диапазона a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите конец диапазона b: ");
        int b = int.Parse(Console.ReadLine());
        int randomNumber = rnd.Next(a, b + 1);
        Console.WriteLine($"Случайное число из диапазона [{a}, {b}]: {randomNumber}");
        Console.ReadKey();
    }
}
