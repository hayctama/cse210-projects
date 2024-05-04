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

            // Entry entry = new Entry();
            // GeneratePrompt _newPrompt = new GeneratePrompt();

            // Console.Write($"{_newprompt}");
            // string newResponse = Console.ReadLine();
            // string newDate = DateTime.Now.ToString("MM/dd/yyyy");
            // _entries.Add(new Entry(_promptText, _EntryText, _date));
    public void DisplayAll()
    // need to loop through entire entry list here
    {

        // Entry e = new Entry();
        // e.Display();
        // DateTime theCurrentTime = DateTime.Now;
        // string dateText = theCurrentTime.ToShortDateString()
        
        foreach(Entry Entry in _entries)
        {
            Entry.Display();
        }
    }

    // public void SaveToFile(string fileName)
    // Loop through each item in entries and save it in a file
    // {
    //     string Journal.txt = "myFile.txt";

    //     using (StreamWriter outputFile = new StreamWriter(Journal.txt))
    //     {
    //         // You can add text to the file with the WriteLine method
    //         outputFile.WriteLine("This will be the first line in the file.");
            
    //         // You can use the $ and include variables just like with Console.WriteLine
    //         string color = "Blue";
    //         outputFile.WriteLine($"My favorite color is {color}");
    //     }
    // }

    // public void LoadFromFile(string file)
    // // Loop through each line in the file and create entry objects to put in the list.
    // //may need to clear something?
    // {
    //     string filename = "myFile.txt";
    //     string[] lines = System.IO.File.ReadAllLines(filename);

    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split(",");
    //         string _date = parts[0];
    //         string _promptText = parts[1];
    //     }
    // }
}