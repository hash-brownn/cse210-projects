public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public void StartMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to {_name} Activity");
        System.Console.WriteLine();
        System.Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like this session to last? ");
        _duration = int.Parse(Console.ReadLine());
    }



    protected void Spinner(int duration){
        List<string> animationchars = new List<string>{"|", "/", "-", "\\"};
        DateTime startTime = DateTime.Now;
        DateTime future = startTime.AddSeconds(duration);
        int i = 0;
        while (DateTime.Now < future){
            
            Console.Write(animationchars[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            
            if (i >= animationchars.Count){
                i = 0;
            }
        }
    }
    protected void CountDown(int duration){
        for (int i=duration;i>0;i--){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
    public void GetReady(){
        Console.Clear();
        System.Console.WriteLine("Get ready...");
        Spinner(5);
    }

    public void EndMessage(){
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine("Well DONE!!");
        Spinner(5);
        System.Console.WriteLine();
        System.Console.WriteLine($"You have completed {_duration} seconds of {_name} Activity");
        Spinner(5);
    }



    public void AddToLog(){
        using (StreamWriter writer = File.AppendText("activitylogs.txt")){
            DateTime currentTime = DateTime.Now;
            writer.WriteLine($"You did {_name} activity for {_duration} seconds - {currentTime}");
        }
    }
    public void CheckLogs(){
        Console.Clear();
        if (File.Exists("activitylogs.txt")){
            using (StreamReader reader = new StreamReader("activitylogs.txt")){
                int i = 1;
                int breathing = 0;
                int reflection = 0;
                int listing = 0;
                while(!reader.EndOfStream){
                    
                    string line = reader.ReadLine();
                    if(line.Contains("Breathing")){
                        breathing++;
                    }else if (line.Contains("Reflection")){
                        reflection++;
                    }else if(line.Contains("Listing")){
                        listing++;
                    }
                    System.Console.WriteLine($"{i}. {line}");
                    i++;
                }
                System.Console.Write($"\nBreathing: {breathing}, Reflection: {reflection}, Listing: {listing}\n");
                
            }
            Console.Write("Press enter to exit logs:");
            Console.ReadLine();
            
        }
        else{
            System.Console.WriteLine("You haven't done any activity yet!");
            Spinner(5);
        }
    }

}