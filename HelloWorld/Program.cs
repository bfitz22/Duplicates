using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen.");
            var input = Console.ReadLine();
            var numbers = new List<int>();
            if (input.Length > 0)
            {
                foreach (var number in input.Split('-'))
                    numbers.Add(Convert.ToInt32(number));
            }
            else if (string.IsNullOrWhiteSpace(input))
                return; 
            var uniques = new List<int>();
            var duplicatesExist = false; 

            foreach(var number in numbers)
            {
                if (uniques.Contains(number))
                {
                    duplicatesExist = true;
                    break;
                }
                else
                    uniques.Add(number);
            }
            var answer = duplicatesExist ? "Duplicates" : "No Duplicates";
            Console.WriteLine(answer);
        }

    }
}
