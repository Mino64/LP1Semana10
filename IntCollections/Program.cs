using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> listy = new List<int>();
            Stack<int> stacky = new Stack<int>();
            Queue<int> queuey = new Queue<int>();
            HashSet<int> hashSety = new HashSet<int>();

            int[] values = {1,10, -30, 10, -5};

            foreach (int num in values)
            {
                listy.Add(num);
                stacky.Push(num);
                queuey.Enqueue(num);
                hashSety.Add(num);
            }

            Console.WriteLine($"List: {string.Join(", ", listy)}");
            Console.WriteLine($"Stack: {string.Join(", ", stacky)}");
            Console.WriteLine($"Queue: {string.Join(", ", queuey)}");
            Console.WriteLine($"HashSet: {string.Join(", ", hashSety)}");
        }
    }
}
