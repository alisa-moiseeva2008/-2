using System;
internal class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        a = b = c = 2;
        double z = a * b + c++ / b - a * b * --c;
        Console.WriteLine($"Исходное выражение (a=2, b=2, c=2): {z}");      
        a = b = c = 2;
        double z1 = (a * b + c++) / (b - a) * b * --c;
        Console.WriteLine($"а) Результат 3.66: {z1:F2}");   
        a = b = c = 2;
        double z2 = a * b + c++ / (b - a) * b * --c;
        Console.WriteLine($"б) Результат -1: {z2}");  
        a = b = c = 2;
        double z3 = a * (b + c++) / b - a * b * --c;
        Console.WriteLine($"в) Результат 2: {z3}");  
        a = b = c = 2;
        double z4 = a * b + c++ / (b - a * b * --c);
        Console.WriteLine($"г) Результат -2: {z4}"); 
        a = b = c = 2;
        double z5 = a * (b + c++) / (b - a) * b * --c;
        Console.WriteLine($"д) Результат -4: {z5}");
        Console.ReadKey();
    }
}
