using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStaticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //
            var stack = new Stack<int>();

            for (int i = 0; i < commands[0] && numbers.Length>i; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int j = 0; j < commands[1] && stack.Count>0; j++)
            {
                stack.Pop();
            }
            Console.WriteLine(stack.Count == 0 ? "0": stack.Contains(commands[2])? "true": $"{stack.Min()}");
        }
    }
}
