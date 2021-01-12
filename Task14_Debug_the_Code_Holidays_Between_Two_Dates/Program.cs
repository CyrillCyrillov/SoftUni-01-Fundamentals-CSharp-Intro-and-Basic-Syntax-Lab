using System;
using System.IO;
using System.Globalization;

namespace Delete
{

    class Program
    {
        public static System.Globalization.CultureInfo InvariantCulture;
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.MM.yyyy", CultureInfo.InvariantCulture);
            int holidaysCount = 0;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount += 1;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }
}

