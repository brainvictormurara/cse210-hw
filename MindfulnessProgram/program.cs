// EXCEEDING REQUIREMENTS: 
// 1. Added a session counter to track how many activities the user completes in one sitting.
// 2. Added logic to ensure the "Reflecting" questions don't repeat until all are used.

class Program
{
    static void Main(string[] args)
    {
        int sessionsCompleted = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine($"Activities completed this session: {sessionsCompleted}");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            if (choice == "1") { 
                new BreathingActivity().Run(); 
                sessionsCompleted++; 
            }
            else if (choice == "2") { 
                new ReflectingActivity().Run(); 
                sessionsCompleted++; 
            }
            // Add case for ListingActivity here...
            else if (choice == "4") break;
        }
    }
}
