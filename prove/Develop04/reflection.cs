using System.Text.Json;
public class Reflection : Activity
{
    private Dictionary<string, List<string>> _reflectiveQuestions = new Dictionary<string, List<string>>();
    private KeyValuePair<string, List<string>> _reflectiveQuestion = new KeyValuePair<string, List<string>>();


    public Reflection(){
        _name = "Reflection";
        _description = "This activity will help you reflect on different moments in your life.";
    }

    private void GetRandomReflection(){
        using (StreamReader reader = new StreamReader("reflections.json")){
            string json = reader.ReadToEnd();
            _reflectiveQuestions = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
        }
        Random random = new Random();
        int randomIndex = random.Next(_reflectiveQuestions.Count);
        _reflectiveQuestion = _reflectiveQuestions.ElementAt(randomIndex);
    }

    public void Run(){
        GetRandomReflection();
        System.Console.WriteLine();
        DisplayPrompt();
        System.Console.WriteLine();
        DisplayFollowUpQuestions();
        


    }
    private void DisplayPrompt()
    {
        
        System.Console.WriteLine("Consider the following prompt:");
        System.Console.WriteLine();
        System.Console.WriteLine($"---{_reflectiveQuestion.Key}---\n");
        System.Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    private void DisplayFollowUpQuestions(){
        System.Console.WriteLine("Ponder on each of the following questions based on this experience.");
        Console.Write("You may begin in.. ");
        CountDown(3);
        Console.Clear();
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime){
            foreach (string question in _reflectiveQuestion.Value){
                Console.Write($"> {question} ");
                if (_duration > 50){
                    Spinner(_duration / 5);
                }
                else{
                    Spinner(10);
                }
                if (DateTime.Now >= futureTime)
                {
                    break;
                }
                
                System.Console.WriteLine();
                
            }
        }
    }


    
}