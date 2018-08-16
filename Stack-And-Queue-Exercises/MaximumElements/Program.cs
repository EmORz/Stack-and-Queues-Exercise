using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaximumElements
{
    class Program
    {

        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxHistoty = new Stack<int>();
            maxHistoty.Push(int.MinValue);
            var result = new StringBuilder();


            for (int i = 0; i < num; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (command[0])
                {

                    case 1:
                        if (command.Length > 1)
                        {
                            stack.Push(command[1]);
                            if (command[1] > maxHistoty.Peek())
                            {
                                maxHistoty.Push(command[1]);
                            }
                        }
                        break;
                    case 2:
                        if (stack.Count>0)
                        {
                            var temp = stack.Pop();
                            if (temp == maxHistoty.Peek())
                            {
                                maxHistoty.Pop();
                            }
                        }
                        break;
                    case 3:
                        result.Append($"{maxHistoty.Peek()}\n");
                        break;
                }

            }
            Console.WriteLine(result);
        }
    }
}
