using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToCsv());
            }
        }
        Console.WriteLine("Your Journal was saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                _entries.Add(Entry.FromCsv(line));
            }
            Console.WriteLine("Your Journal is loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
