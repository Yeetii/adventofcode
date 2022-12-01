using System;
using System.Collections.Generic;

namespace AdventOfCode2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.IO.File.ReadAllLines(@"input.txt");
            List<int> elveCalories = new List<int>(){0};
            foreach (string line in input)
            {                
                if (line == ""){
                    elveCalories.Add(0);
                } else {
                    int calories = Int32.Parse(line);
                    elveCalories[elveCalories.Count - 1] += calories;
                }
            }      
            int maxCalories = 0;
            foreach (int elveCal in elveCalories){
                if (maxCalories < elveCal){
                    maxCalories = elveCal;
                }
            }
            Console.WriteLine(maxCalories);
        }
    }
}