using System;

class Program
{
    static void Main(string[] args)
    {
        // CREATIVITY & EXCEEDING REQUIREMENTS:
        // 1. Added a Leveling System: Every 1000 points, the user's Rank increases.
        // 2. Added defensive checks in RecordEvent to prevent crashing on bad input.
        // 3. Added a clear header and separators for the "List Goals" view to improve readability.

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
