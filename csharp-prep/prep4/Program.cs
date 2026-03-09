using System;
using System.Collections.Generic; // This is required to use Lists!

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // 1. Collect the numbers
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            
            // Only add to the list if it's not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // 2. Compute the Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // 3. Compute the Average
        // We use (float) to ensure the division allows for decimals
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // 4. Find the Maximum
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}