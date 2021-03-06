using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2017
{
    public static class Functions
    {
        public static void Print(List<int> collection, Action<List<int>> action)
        {
            action(collection);
        }
        public static List<int> ApplyFunc(List<int> collection, Func<int, int> func)
        {
            List<int> result = new List<int>();
            foreach (var item in collection)
            {
                int modifiedItem = func(item);
                result.Add(modifiedItem);
                // result.Add(func(item));
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = Functions.ApplyFunc(numbers, x => x + 1);
                        break;
                    case "subtract":
                        numbers = Functions.ApplyFunc(numbers, x => x - 1);
                        break;
                    case "multiply":
                        numbers = Functions.ApplyFunc(numbers, x => x * 2);
                        break;
                    case "print":
                        Functions.Print(numbers, x => Console.WriteLine(string.Join(" ", numbers)));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

        }
    }
}
