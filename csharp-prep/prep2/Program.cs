using System;

class Program
{
    static void Main(string[] args)
    {
        // Core 1 & 2: Get the percentage and convert to a number
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        // Core 3: Use a variable to store the letter
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Display the letter grade
        Console.WriteLine($"Your grade is: {letter}");
        
        // Check if the user passed
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Keep working hard! You can do it next time.");
        }
    }
}
