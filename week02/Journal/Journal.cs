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
        if (_entries == null || _entries.Count == 0)
        {
            Console.WriteLine("There is no entries in the journal");
        }
        foreach (var e in _entries)
            {
                e.Display();
                Console.WriteLine();
            }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();

        if (string.IsNullOrWhiteSpace(file))
        {
            Console.WriteLine("Invalid filename.");
            return;
        }

        if (!File.Exists(file))
        {
            Console.WriteLine($"The file {file} doesn't exist.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
        
    }
}