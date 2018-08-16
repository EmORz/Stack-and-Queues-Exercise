using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculateSequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            queue.Enqueue(n);
            long s = 0;
            var temp = 0;
            for (int i = 0; i < 49; i++)
            {
                switch (i % 3)
                {
                    case 0:
                        s = queue.ToArray().Skip(temp).Take(1).ToArray()[0];
                        queue.Enqueue(s + 1);
                        temp++;
                        break;
                    case 1:
                        queue.Enqueue(2 * s + 1);
                        break;
                    case 2:
                        queue.Enqueue(s + 2);
                        break;                  
                }
            }
            Console.WriteLine(string.Join(" ", queue));

        }
    }
}
