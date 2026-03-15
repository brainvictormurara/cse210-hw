using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\n{prompt}");
                Console.Write("> ");
                string response = Console.ReadLine() ?? "";
                
                Console.Write("How was your mood (1-10)? ");
                int mood = int.Parse(Console.ReadLine() ?? "5");

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine() ?? "";
                theJournal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine() ?? "";
                theJournal.SaveToFile(fileName);
            }
        }
    }
}