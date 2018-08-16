using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var text = new StringBuilder();
            var history = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split( new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                var command = int.Parse(line[0]);

                switch (command)
                {
                    case 1:
                        if (line.Length > 1)
                        {
                            history.Push(text.ToString());
                            text.Append(line[1]);
                        }                       
                        break;
                    case 2:
                        if (line.Length > 1)
                        {
                            history.Push(text.ToString());
                            text.Remove(text.Length - int.Parse(line[1]), int.Parse(line[1]));
                        }               
                        break;
                    case 3:
                        if (line.Length > 1)
                        {
                            Console.WriteLine(text[int.Parse(line[1]) - 1]);
                        }
                        break;
                    case 4:
                        text.Clear();
                        text.Append(history.Pop());
                        break;
                    default:
                        break;
                }


            }
        }

    
    }
}
