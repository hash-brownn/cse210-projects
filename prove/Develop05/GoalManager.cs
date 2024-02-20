using System.Net.NetworkInformation;

public class GoalManager
{
    private List<Goal> _unfinishedgoals = new List<Goal>();
    private List<Goal> _allgoals = new List<Goal>();
    private int _totalScore = 0;
    private int _level;
    private int _previouslevel;

    public void Start(){
        if(File.Exists("quests.csv")){
            LoadQuests();
            RemoveFinishedQuests();
        }
        bool runloop = true;
        ManageLevel();
        _previouslevel = _level;
        
        
        while (runloop){
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("-----LIFE QUESTS----");
            DisplayLevel();
            LevelUpMessage();
            System.Console.WriteLine();
            System.Console.WriteLine("Achieve goals and level up your life");
            System.Console.WriteLine("Menu Option:");
            System.Console.WriteLine("1. Start a new Goal.");
            System.Console.WriteLine("2. Current Goals");
            System.Console.WriteLine("3. Mark Goals");
            System.Console.WriteLine("4. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch(choice){
                case "1":
                    Console.Clear();
                    CreateGoal();
                    break;
                case "2":
                    Console.Clear();
                    ListGoals();
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    RecordEvent();
                    RemoveFinishedQuests();
                    break;
                case "4":
                    runloop = false;
                    break;
                default:
                    break;    

            }
        }
        



    }
    public void CreateGoal(){
        System.Console.WriteLine("The type of Goals are:");
        System.Console.WriteLine("1. Simple Goal");
        System.Console.WriteLine("2. Eternal Goal");
        System.Console.WriteLine("3. CheckList Goal");
        Console.Write("Select a goal: ");
        string goalchoice = Console.ReadLine();
        if (goalchoice == "1"){
            SimpleGoal goal = new SimpleGoal();
            goal.SetGoal();
            _unfinishedgoals.Add(goal);
            _allgoals.Add(goal);
        }else if(goalchoice == "2"){
            EternalGoal goal = new EternalGoal();
            goal.SetGoal();
            _unfinishedgoals.Add(goal);
            _allgoals.Add(goal);
        }else if(goalchoice == "3"){
            ChecklistGoal goal = new ChecklistGoal();
            goal.SetGoal();
            _unfinishedgoals.Add(goal);
            _allgoals.Add(goal);
            
        }else{
            
        }
        SaveQuests();
    }
    public void ListGoals(){
        if (_allgoals.Count > 0){
            foreach (Goal goal in _allgoals){
            System.Console.WriteLine(goal.GetDetailsString());
        }
        }
        else{
            System.Console.WriteLine("You have no goals.");
        }
        
    }
    public void RecordEvent(){
        if (_unfinishedgoals.Count > 0){
            System.Console.WriteLine("Which goal did you accomplish?");
            foreach (Goal goal in _unfinishedgoals){
                System.Console.WriteLine($"{_unfinishedgoals.IndexOf(goal) + 1}. {goal.GetName()}");
            }
            Console.Write("Select a goal: ");
            int goalchoice = int.Parse(Console.ReadLine());
           
            try{
            _unfinishedgoals[goalchoice - 1].RecordEvent();
            _totalScore += _unfinishedgoals[goalchoice - 1].GetPoints();
            }
            catch (Exception e){
                
            }
            finally{
                
            }
            
            
        SaveQuests();
        }else{
            System.Console.WriteLine("You have no goals.");
            Console.ReadLine();
        }
        
        
       
    }

    public void SaveQuests(){
        using (StreamWriter writer = new StreamWriter("quests.csv")){
            writer.WriteLine(_totalScore);
            foreach(Goal goal in _allgoals){
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadQuests(){
        using (StreamReader reader = new StreamReader("quests.csv")){
            _totalScore = int.Parse(reader.ReadLine());
            while (!reader.EndOfStream){
                string line = reader.ReadLine();
                string[] parts = line.Split(",\"");

                List<string> section = new List<string>();
                foreach (string part in parts){
                    section.Add(part.Trim('"'));
                }

                if (section[0] == "SimpleGoal"){
                    SimpleGoal goal = new SimpleGoal(section[1], section[2], int.Parse(section[3]), bool.Parse(section[4]));
                    _unfinishedgoals.Add(goal);
                    _allgoals.Add(goal);
                }
                else if(section[0] == "EternalGoal"){
                    EternalGoal goal = new EternalGoal(section[1], section[2], int.Parse(section[3]));
                    _unfinishedgoals.Add(goal);
                    _allgoals.Add(goal);
                }
                else if(section[0] == "CheckListGoal"){
                    ChecklistGoal goal = new ChecklistGoal(section[1], section[2], int.Parse(section[3]),  int.Parse(section[4]), int.Parse(section[5]));
                    _unfinishedgoals.Add(goal);
                    _allgoals.Add(goal);
                }

            }
        }
    }
    public void RemoveFinishedQuests(){
        List <Goal> toremove = new List<Goal>();
        foreach(Goal quests in _unfinishedgoals){
            if(quests.IsComplete()){
                toremove.Add(quests);
            }
        }
        foreach (Goal goal in toremove){
            _unfinishedgoals.Remove(goal);
        }


    }
    public void DisplayLevel(){
        System.Console.WriteLine($"Score: {_totalScore}");
        int reducednumber = _totalScore;
        if (_totalScore > 100){
            reducednumber = _totalScore % 100;
        }
        ManageLevel();
        

        System.Console.WriteLine($"Level :{_level}");
        double score = reducednumber / 10;
        score = Math.Floor(score);
        score = score * 10;
        ConsoleColor previousColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("  [[");
        
        for (int i = 0; i<score;i = i+10){
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("||");
        }
        for (int i = 100; i>score; i= i-10){
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("==");
        }
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("]]");

        Console.ForegroundColor = previousColor;
    }

    public void LevelUpMessage(){
        if(_level > _previouslevel){
            _previouslevel = _level;
            System.Console.WriteLine();
            Console.WriteLine("**CONGRATULATIONS! YOU HAVE LEVELED UP.**");
        }
    }
    public void ManageLevel(){
        if (_totalScore > 100){
            _level = _totalScore / 100;
        }
    }

}