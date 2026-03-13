using System;

// CREATIVITY AND EXCEEDING REQUIREMENTS:
// 1. Added a "Mood Tracker" (1-10 scale) to each entry to capture emotional context.
// 2. Implemented a custom delimiter (~|~) to handle cases where users might type 
//    commas or quotes in their entries, preventing file corruption.
// 3. Added a check to clear current entries when loading a new file to meet specs.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int userChoice = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (userChoice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();
            
            if (int.TryParse(input, out userChoice))
            {
                if (userChoice == 1) // Write
                {
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    
                    Console.Write("On a scale of 1-10, how was your mood? ");
                    string mood = Console.ReadLine();

                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = response;
                    entry._mood = mood;

                    journal.AddEntry(entry);
                }
                else if (userChoice == 2) // Display
                {
                    journal.DisplayAll();
                }
                else if (userChoice == 3) // Load
                {
                    Console.Write("What is the filename? ");
                    string fileName = Console.ReadLine();
                    journal.LoadFromFile(fileName);
                }
                else if (userChoice == 4) // Save
                {
                    Console.Write("What is the filename? ");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                }
            }
        }
        Console.WriteLine("Goodbye!");
    }
}
