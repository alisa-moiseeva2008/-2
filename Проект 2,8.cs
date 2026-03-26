using System;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число a: ");
            int a = int.Parse(Console.ReadLine());            
            int square = a * a;
            Console.WriteLine($"Квадрат числа {a} = {square}");           
            Console.ReadKey();
        }
    }
}