using System;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите массу тела (m): ");
            double m = double.Parse(Console.ReadLine());           
            Console.Write("Введите объем тела (V): ");
            double V = double.Parse(Console.ReadLine());            
            double p = m / V;            
            Console.WriteLine($"Плотность материала: {p}");           
            Console.ReadKey();
        }
    }
}