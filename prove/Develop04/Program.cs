using System;

class Program
{
    static void Main(string[] args)
    {

        bool quit = false;
        while(!quit){
            Console.Clear();
            System.Console.WriteLine("WELCOME TO MINDFULNESS PROGRAM");
            System.Console.WriteLine("Mindfulness menu:");
            System.Console.WriteLine(" 1. Start breathing activity");
            System.Console.WriteLine(" 2. Start reflection activity");
            System.Console.WriteLine(" 3. Start listing activity");
            System.Console.WriteLine(" 4. Check Logs");
            System.Console.WriteLine(" 5. Quit");
            Console.Write("Select one from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
   
                    Breathing breathing = new Breathing();
                    breathing.StartMessage();

                    breathing.GetReady();
                    breathing.Run();
                    breathing.EndMessage();
                    breathing.AddToLog();

                    break;
                case 2:
         
                    Reflection reflecting = new Reflection();
                    reflecting.StartMessage();
    
                    reflecting.GetReady();
                    reflecting.Run();
                    reflecting.EndMessage();
                    reflecting.AddToLog();
                    break;
                case 3:
    
                    Listing listing = new Listing();
                    listing.StartMessage();

                    listing.GetReady();
                    listing.Run();
                    listing.EndMessage();
                    listing.AddToLog();
                    break;

                case 4 :
                    Activity activity = new Activity();
                    activity.CheckLogs();
                    break;
                case 5 :
                    quit = true;
                break;
                default:
                    quit = true;
                    break;
            }
            
        }
        

    }
}