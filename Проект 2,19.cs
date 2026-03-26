using System;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения ax^2 - bx + c = e");          
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());           
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());         
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());      
            Console.Write("Введите e: ");
            double e = double.Parse(Console.ReadLine());
            double c1 = c - e;          
            double discriminant = b * b - 4 * a * c1;          
            if (discriminant > 0)
            {
                double x1 = (b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x = b / (2 * a);
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
            }           
            Console.ReadKey();
        }
    }
}