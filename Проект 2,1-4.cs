using System;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();         
            Console.WriteLine("Случайные числа:");
            Console.WriteLine(rnd.Next()); 
            Console.WriteLine(rnd.Next(5)); 
            Console.WriteLine(rnd.Next(-5, 5));         
            Console.ReadKey();
        }
    }
}