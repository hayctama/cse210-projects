using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.IO.Enumeration;

/*
I have this meditation app that I use everynight that asks for my mood before the meditation. So I decided
to add that feature to my journal app! You write it in the write section and can save and load it
just like the other items.
*/

class Program
{


    
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        String choice;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What number do you pick? ");
            Console.Write("> ");
            choice = Console.ReadLine();

            //WRITE
            if (choice == "1")
            {
                DateTime theCurrentTime = DateTime.Now;
                string _dateText = theCurrentTime.ToShortDateString();

                Console.WriteLine("On a scale from 1-10, how is your mood today? ");
                Console.Write("> ");
                string moodText = Console.ReadLine();

                PromptGenerator rP = new PromptGenerator();
                string promptText = rP.GetRandomPrompt();
                Console.WriteLine(promptText);
                Console.Write("> ");
                string entryText = Console.ReadLine();
                
                Entry newEntry = new Entry();
                newEntry._date = _dateText;
                newEntry._promptText = promptText;
                newEntry._todaysMood = moodText;
                newEntry._entryText = entryText;

                journal.AddEntry(newEntry);
    
                // Create an entry object to pass to the journal for storage
            }

            // DISPLAY
            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            // LOAD
            else if (choice == "3")
            {
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                journal.DisplayAll();
            }

            // SAVE
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("It is saved!");
            }

            // QUIT
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
            }

            // BACKUP
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine();
        }
        while (choice != "5");
    }
}


