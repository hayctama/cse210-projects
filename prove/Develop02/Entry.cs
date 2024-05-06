using System;
using System.Security.Cryptography;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _todaysMood;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood on a scale from 1-10: {_todaysMood}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}