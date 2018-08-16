using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rversed_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            var stack = new Stack<long>(numArray);
            
            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
