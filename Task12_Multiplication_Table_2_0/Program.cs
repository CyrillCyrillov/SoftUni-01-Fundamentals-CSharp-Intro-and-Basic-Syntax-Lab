using System;

namespace Task12_Multiplication_Table_2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            if (b > 10 )
                {
                    Console.WriteLine($"{a} X {b} = {a * b}");
                }
            else
                {
                    for (int i = b; i <= 10; i++)
                    {
                        Console.WriteLine($"{a} X {i} = {a * i}");
                    }
                }
        }
    }
}
