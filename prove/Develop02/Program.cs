using System;
using System.IO;
using System.IO.Enumeration;
class Program
{
    static void Main(string[] args)
    {
        // Making the journal object to be called and utilized later
        Journal journal = new Journal();

        Console.WriteLine("WELCOME TO DAY JOURNAL!");
        while (true)
        {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Please select one of the following");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Delete Entry");
        Console.WriteLine("5. Save");
        Console.WriteLine("6. Quit");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();


    // writing new entry
        if (choice == "1")
        {
            // generating random prompt
            Prompt prompt = new Prompt();
            string randomPrompt = prompt.PromptGenerator();
            Console.Write(randomPrompt);
            string body = Console.ReadLine();

        //saving the prompt and answer in entry object
            Entry e = new Entry();
            e._prompt = randomPrompt;
            e._body = body;
            DateTime currentTime = DateTime.Now;
            e._dateText = currentTime.ToShortDateString();

        // adding entry to journal
            journal.AddEntry(e);
            



        }

        // displaying journal
        else if (choice == "2")
        {
            Console.WriteLine();
            Console.WriteLine("displaying...");
            Console.WriteLine();
            
            journal.DisplayJournal();
        }

        // loading journal from already existing file
        else if (choice == "3")
        {
            Console.Write("What is the filename?(type 0 to go back) ");
            string filename = Console.ReadLine();
            if (filename == "0")
            {
                continue;
            }
            
            journal.LoadingJournal(filename);
            
            Console.WriteLine();
            Console.WriteLine("File Loaded!!");
            Console.WriteLine();
            
        }

        // deleting entry
        else if (choice == "4")
        {
        // displaying entry to select from, when making the decision of deleting
            foreach (Entry e in journal._entries)
            {
        
                Console.WriteLine($"{journal._entries.IndexOf(e) + 1} - {e._prompt}");

            }
            Console.Write("Which entry do you want to delete?(type 0 to go back) ");
            
            int entryToDelete = int.Parse(Console.ReadLine());
             if (entryToDelete == 0)
            {
                continue;
            }
            journal.DeleteEntry(entryToDelete);
            Console.WriteLine();
            Console.WriteLine("Entry Deleted!");
            Console.WriteLine();

        }

        // saving file
        else if (choice == "5")
        {
            Console.Write("What is the filename?(type 0 to go back) ");
            string filename = Console.ReadLine();
            if (filename == "0")
            {
                continue;
            }
            
            journal.SaveToFile(filename);
            Console.WriteLine();
            Console.WriteLine("File Saved!");
            Console.WriteLine();
        }
        else
        {
            break;
        }
        }

    } 


}