using System;

namespace RecursiveFibonacci
{
    class Program
    {
        private static long[] memo;

        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            memo = new long[number + 1];
            var fibonacciResult = Fibonacci(number);
            Console.WriteLine(fibonacciResult);
        }

        private static long Fibonacci(int n)
        {
            if (n<=2)
            {
                return 1;
            }
            if (memo[n] == 0)
            {
                memo[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            return memo[n];
        }
    }
}
