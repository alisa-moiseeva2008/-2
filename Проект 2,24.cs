using System;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            int a1 = a;
            a1 = a1 * a1; 
            a1 = a1 * a1; 
            Console.WriteLine($"a^4 = {a1} (за 2 операции)");
            int a2 = a;
            a2 = a2 * a2; 
            a2 = a2 * a2; 
            a2 = a2 * a * a; 
            Console.WriteLine($"a^6 = {a2} (за 3 операции)");
            int a3 = a;
            a3 = a3 * a3; 
            a3 = a3 * a3; 
            a3 = a3 * a3; 
            a3 = a3 / a; 
            Console.WriteLine($"a^7 = {a3} (за 4 операции)");           
            int a4 = a;
            a4 = a4 * a4; 
            a4 = a4 * a4; 
            a4 = a4 * a4; 
            Console.WriteLine($"a^8 = {a4} (за 3 операции)");
            int a5 = a;
            a5 = a5 * a5; 
            a5 = a5 * a5; 
            a5 = a5 * a5; 
            a5 = a5 * a; 
            Console.WriteLine($"a^9 = {a5} (за 4 операции)");
            int a6 = a;
            a6 = a6 * a6; 
            a6 = a6 * a6; 
            a6 = a6 * a6; 
            a6 = a6 * a * a; 
            Console.WriteLine($"a^10 = {a6} (за 4 операции)");          
            Console.ReadKey();
        }
    }
}