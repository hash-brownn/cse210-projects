public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();
    private string _prompt;


    public Listing(){
        _name = "Listing";
        _description = "This activity will help you list the times that meaningful moments happened in your life.";
    }
    private void GetRandomPrompt()
    {
        using(StreamReader reader = new StreamReader("prompts.txt"))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                _prompts.Add(line);
            }
        }

        Random random = new Random();
        _prompt = _prompts[random.Next(_prompts.Count)];

    }

    public void Run(){
        GetRandomPrompt();
        System.Console.WriteLine();
        System.Console.WriteLine("List as many responses you can to the following prompt:");
        System.Console.WriteLine($"---{_prompt}---");
        Console.Write("You may begin in.. ");
        CountDown(4);
        
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime){
            System.Console.WriteLine();
            Console.Write(">");
            string response = Console.ReadLine();
            _responses.Add(response);
            
        }
        System.Console.WriteLine($"\nYou wrote {GetResponseList()} response/s!");
    }
    private int GetResponseList(){
        return _responses.Count;
    }
}