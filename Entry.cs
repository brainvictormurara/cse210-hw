using System;

public class Entry
{
    // Initializing with = ""; removes the "non-nullable" warnings
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public string _mood = ""; 

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}/10");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("---------------------------------------------");
    }
}