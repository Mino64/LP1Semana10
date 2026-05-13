using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string fileName = args[0];
            Queue<string> inputQueue = new();

            Console.WriteLine($"Enter string");

            string input;

            do
            {
                input = Console.ReadLine();
                if(input != string.Empty)
                {
                    inputQueue.Enqueue(input);
                }
            }
            while (input != string.Empty);

            File.WriteAllLines(fileName, inputQueue);

        }
    }
}
