using System;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public int _mood; 

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}/10");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}