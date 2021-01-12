using System;

namespace Task10_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 1;
            int count = 0;
            while (count < n)
            {
                if (number % 2 != 0)
                    {
                        Console.WriteLine(number);
                        sum += number;
                        count += 1;
                    }
                
                number += 1;
            }
            
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
