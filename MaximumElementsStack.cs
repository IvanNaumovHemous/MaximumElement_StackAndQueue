using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElementsStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var list = new List<int>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var type = input[0];
                
                switch (type)
                {
                    case "1":
                        var numberToPush = int.Parse(input[1]);
                        stack.Push(numberToPush);
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        var maxElement = stack.Max();
                        list.Add(maxElement);
                        break;
                }

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
