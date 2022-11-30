using System;

namespace AdventOfCode2022
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read input
            string[] input = System.IO.File.ReadAllLines(@"input.txt");
            // print all lines of input
            foreach (string line in input)
            {
                Console.WriteLine(line);
            }            
        }
    }
}