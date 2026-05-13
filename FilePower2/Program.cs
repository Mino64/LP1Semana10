using System;
using System.IO;

namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string fileName = args[0];

            Console.WriteLine($"Enter string");

            string input;

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                do
                {
                    input = Console.ReadLine();
                    if (input != string.Empty)
                    {
                        writer.WriteLine(input);
                    }
                }
                while (input != string.Empty);
            }


        }
    }
}
