using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var numberOfElementsEnqueue = commands[0];
            var numberOfElemtsDequeue = commands[1];
            var searchedNum = commands[2];
            //
            var queue = new Queue<int>();
            Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Skip(numberOfElemtsDequeue)
                   .Select(int.Parse)
                   .ToList()
                   .ForEach(n => queue.Enqueue(n));
            Console.WriteLine(queue.Contains(searchedNum) ? "true": queue.Count()==0 ? "0": $"{queue.Min()}");
        }
    }
}
