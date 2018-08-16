using System;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fuel =0;
            var startIndex = 0;

            for (int i = 0; i < n; i++)
            {
                var pipeINFO = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var amountOfPetrol = pipeINFO[0];
                var distance = pipeINFO[1];
                 // 1:1
                fuel += amountOfPetrol - distance;
                if (fuel<0)
                {
                    fuel = 0;
                    startIndex = i+1;
                }
            }
            Console.WriteLine(startIndex);
        }
    }
}
