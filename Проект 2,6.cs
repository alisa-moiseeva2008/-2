using System;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;
            c = a + (double)b + c;            
            Console.WriteLine($"Результат: {c}");
            Console.ReadKey();
        }
    }
}