using System;

class Program
{
    static void Main(string[] args)
    {
        // Core 3: Generate a random magic number from 1 to 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // Core 2: Loop until the guess matches the magic number
        while (guess != magicNumber)
        {
            // Core 1: Ask for a guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
