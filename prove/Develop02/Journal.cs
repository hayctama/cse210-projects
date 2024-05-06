using System;
using System.IO;
using System.Collections.Generic;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    // put newEntry into _entries
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    // need to loop through entire entry list here
    {
        foreach(Entry Entry in _entries)
        {
            Entry.Display();
        }
    }

    public void SaveToFile(string filename)
    // Loop through each item in entries and save it in a file
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry newEntry in _entries)
            {
                outputFile.WriteLine($"{newEntry._date}~~{newEntry._promptText}~~{newEntry._todaysMood}~~{newEntry._entryText}");
            }
            
        }
    }

    public void LoadFromFile(string filename)
    // Loop through each line in the file and create entry objects to put in the list.
    //may need to clear something?
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._todaysMood = parts[2];
            newEntry._entryText = parts[3];

            _entries.Add(newEntry);

        }
    }
}