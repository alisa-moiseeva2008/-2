using System;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double e = Math.E;
            double roundedE = Math.Round(e, 1);            
            Console.WriteLine($"Число e: {e}");
            Console.WriteLine($"Число e с точностью до десятых: {roundedE}");            
            Console.ReadKey();
        }
    }
}