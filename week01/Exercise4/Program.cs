using System.Collections.Generic;

using System;
using System.ComponentModel;

class Program
{
    static void Main(string[]args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.WriteLine("Enter number");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        // calculating the sum //
        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculating the average //
        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The Average is: {average}");

            // Finding the largest number //
            int largest = numbers.Max();
            Console.WriteLine($"The Largest number is: {largest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}