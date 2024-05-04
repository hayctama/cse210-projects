using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

/*
PUT CREATIVITY CRAP HERE
*/

class Program
{


    
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

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

                GetRandomPrompt randomPrompt = new GetRandomPrompt();
                string promptText = randomPrompt.ToString();

                
                Console.WriteLine(randomPrompt);
                Console.Write("> ");
                string entryText = Console.ReadLine();
                
                Entry newEntry = new Entry
                {
                    _date = _dateText,
                    _promptText = promptText,
                    _entryText = entryText

                };
                theJournal.AddEntry(newEntry);
    
                // Create an entry object to pass to the journal for storage
            }

            // DISPLAY
            else if (choice == "2")
            {
                Entry e = new Entry();
                e.Display();
            }

            // LOAD
            else if (choice == "3")
            {
            }

            // SAVE
            else if (choice == "4")
            {
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


