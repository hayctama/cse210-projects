using System;
using System.Security.Cryptography;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} : {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}