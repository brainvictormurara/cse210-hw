using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold different types of activities (Polymorphism)
        List<Activity> activities = new List<Activity>();

        // 1. Create instances of each activity
        Running run = new Running("14 Apr 2026", 30, 4.8);
        Cycling bike = new Cycling("15 Apr 2026", 45, 20.5);
        Swimming swim = new Swimming("16 Apr 2026", 20, 25);

        // 2. Add them to the list
        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        // 3. Iterate through the list and display the summaries
        Console.WriteLine("Exercise Tracking Summary:");
        Console.WriteLine("------------------------------------------------------------------");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}