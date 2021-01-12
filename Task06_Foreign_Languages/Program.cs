using System;

namespace Task06_Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string state = Console.ReadLine();

            switch (state)
            {
                case "England":
                case "USA":
                     Console.WriteLine("English");
                     break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
