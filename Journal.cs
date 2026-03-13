using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // Using ~|~ as a separator to ensure commas in user text don't break the load logic
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~|~{e._promptText}~|~{e._entryText}~|~{e._mood}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear(); // Requirements: Replace current entries
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            if (parts.Length == 4)
            {
                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._promptText = parts[1];
                newEntry._entryText = parts[2];
                newEntry._mood = parts[3];
                _entries.Add(newEntry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}