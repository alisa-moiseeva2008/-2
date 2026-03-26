using System;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            double b = 2.6;
            b = a + b;          
            Console.WriteLine($"Результат: {b}");
            Console.ReadKey();
        }
    }
}