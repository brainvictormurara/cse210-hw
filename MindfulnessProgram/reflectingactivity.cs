using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone.",
        "Think of a time when you did something selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "Have you done this before?",
        "How did you start?",
        "How did you feel after?",
        "What made it different?",
        "What did you learn?",
        "How can you apply this?"
    };

    public ReflectionActivity() : base(
        "Reflection Activity",
        "Reflect on times you showed strength and resilience.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();

        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("\nReflect on the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(4);
        }

        EndMessage();
    }
}