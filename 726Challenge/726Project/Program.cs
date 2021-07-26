using System;
using System.Collections.Generic;

namespace _726Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Print your input as space seperated, unique integers");
            Console.WriteLine("Put the target value first, then start creating array");
            string input = Console.ReadLine();
            string[] numbersAsStrings = input.Split(' ');
            List<int> numbers = new List<int>();
            int target = Int32.Parse(numbersAsStrings[0]);
            for (int i = 1; i < numbersAsStrings.Length; i++)
            {
                numbers.Add(Int32.Parse(numbersAsStrings[i]));
            }
            Problem1.SumSubArray(numbers, target);
        }
    }
}
