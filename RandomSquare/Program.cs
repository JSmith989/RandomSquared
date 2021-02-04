using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNums = new List<int>();
            var random  = new Random();

            for (int i = 0; i <= 19; i++)
            {
                randomNums.Add(random.Next(1, 50));
            }
            // wasn't able to get this working but it's worths saving for future maybe?
            /*var twentyRandom = randomNums.OrderBy(x => random.Next()).Take(20);*/
            foreach (var number in randomNums)
            {
                Console.WriteLine($"{number}");
                
            }
            Console.WriteLine("==================================");

            var finalList = new List<int>();
            foreach (var number in randomNums)
            {
                var squared = number * number;
                finalList.Add(squared);
                Console.WriteLine($"{squared}");
            }

            Console.WriteLine("==================================");

            var oddsOut = finalList.Where(number => number % 2 == 0);
            foreach (var number in oddsOut)
            {
                
                Console.WriteLine($"{number}");
            }
        }
    }
}
