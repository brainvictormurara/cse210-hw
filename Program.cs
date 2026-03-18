using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize Reference and Scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own wisdom.";
        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        // Main Program Loop
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            
            userInput = Console.ReadLine() ?? "";

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        // Final screen once all is hidden
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nExcellent job! You have hidden the whole scripture.");
    }
}