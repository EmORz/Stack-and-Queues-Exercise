using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var openChar = new char[]
            {
                '{',
                '[',
                '('
            };

            var closedChar = new char[]
            {
                '}',
                ']',
                ')'
            };

            var input = Console.ReadLine().ToCharArray();
            var parenthesis = new Stack<char>();
            var areBalanced = true;

            foreach (var item in input)
            {
                if (openChar.Contains(item))
                {
                    parenthesis.Push(item);                    
                }
                if (closedChar.Contains(item))
                {
                    if (parenthesis.Count() == 0)
                    {
                        areBalanced = false;
                        break;
                    }
                    var openedSing = parenthesis.Pop();

                    if (!CheckBalanced(openedSing, item))
                    {
                        areBalanced = false;
                        break;
                    }
                }
            }
            Console.WriteLine(areBalanced ? "YES" : "NO");
        }

        private static bool CheckBalanced(char openedSing, char closedSing)
        {
            switch (openedSing)
            {
                case '{':
                    return closedSing == '}' ? true : false;
                case '[':
                    return closedSing == ']' ? true : false;
                case '(':
                    return closedSing == ')' ? true : false;
            }
            return false;
        }
    }
}
