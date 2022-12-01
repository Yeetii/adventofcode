using System;
using System.Collections.Generic;
using System.Linq;

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
            
            elveCalories.Sort();
            int[] maxCalories = {elveCalories[elveCalories.Count -1], elveCalories[elveCalories.Count-2] ,elveCalories[elveCalories.Count-3]};
            
            Console.WriteLine("Calories of no 1 elf: " + elveCalories[elveCalories.Count -1]);
            Console.WriteLine("Sum of top 3 elves: " + maxCalories.Sum());
        }
    }
}