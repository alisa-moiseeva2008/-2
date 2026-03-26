using System;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double c = double.Parse(Console.ReadLine());       
            double rounded = Math.Round(c, 2);
            Console.WriteLine($"Число с точностью до сотых: {rounded}");           
            Console.ReadKey();
        }
    }
}