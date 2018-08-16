using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Take(n)
                .ToArray();
            var days = new int[n];
            var index = new Stack<int>();
            index.Push(0);

            for (int i = 1; i < n; i++)
            {
                var maxDay = 0;
                while (index.Count>0 && plants[index.Peek()] >= plants[i])
                {
                    maxDay = Math.Max(maxDay, days[index.Pop()]);
                }
                if (index.Count > 0)
                {
                    days[i] = maxDay + 1;
                }
                index.Push(i);
            }
            Console.WriteLine(days.Max());
            //Console.ReadKey();


        }
    }
}
