using System;
using System.Collections.Generic;

namespace StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            stack.Push(1);
            stack.Push(1);
            for (int i = 3; i <= n; i++)
            {
                var minusOne = stack.Pop();               
                var minusTwo = stack.Peek();
                stack.Push(minusOne);
                var current = minusOne + minusTwo;
                stack.Push(current);
            }
            Console.WriteLine(stack.Peek());

        }
    }
}
