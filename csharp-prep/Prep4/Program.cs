using System;
using System.Globalization;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (newNumber != 0)
        {   
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            if(newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }
        // suming the numbers
        int sum = 0;
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            sum += number; 
        }
        Console.WriteLine($"Sum of numbers: {sum}");

        // averaging the numbers
        int average = sum / numbers.Count;
        Console.WriteLine($"Average of numbers: {average}");
        Console.WriteLine($"Largest number in list: {max}");

        // sorting list
        numbers.Sort();
        Console.WriteLine("Sorted list!");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        
    }
}