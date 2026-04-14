// EXCEEDING REQUIREMENTS:
// - Implemented a clean inheritance structure with a base Activity class and specialized derived classes.
// - Centralized shared behaviors (start/end messages, spinner animation, countdown) in the base class to avoid duplication.
// - Fixed and fully implemented the Listing Activity to correctly capture and count user input within a timed session.
// - Added spinner animation using backspace control characters for a smoother user experience.
// - Used real-time duration control with DateTime instead of fixed loops for accurate timing.
// - Ensured proper file organization with each class in its own file matching exact naming conventions.
// - Improved input validation in Listing Activity by ignoring empty entries.
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}