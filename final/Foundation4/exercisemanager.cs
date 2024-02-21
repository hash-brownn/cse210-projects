public class ExerciseManager
{
    private List<Exercise> _exercises = new List<Exercise>();

     public void Start(){
        bool runloop = true;
        while(runloop){
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("---Journal your exercises---");
            System.Console.WriteLine("1. New entry.");
            System.Console.WriteLine("2. View Journal.");
            System.Console.WriteLine("3. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch(choice){
                case "1":
                    Console.Clear();
                    CreateExercise();
                    break;
                case "2":
                    Console.Clear();
                    DisplayExercises();
                    Console.ReadLine();
                    break;
                case "3":
                    runloop = false;
                    break;
                default:
                    break;    

            }
        }
    }

    public void CreateExercise(){
        System.Console.WriteLine("Which type of Exercise did you do today?");
        System.Console.WriteLine("1. Running");
        System.Console.WriteLine("2. Cycling");
        System.Console.WriteLine("3. Swimming");
        Console.Write("Select exercise: ");
        string exercisechoice = Console.ReadLine();
        if (exercisechoice == "1"){
            Running exercise = new Running();
            exercise.SetExercise();
            _exercises.Add(exercise);


        }else if(exercisechoice == "2"){
            Cycling exercise = new Cycling();
            exercise.SetExercise();
            _exercises.Add(exercise);
        }else if(exercisechoice == "3"){
            Swimming exercise = new Swimming();
            exercise.SetExercise();
            _exercises.Add(exercise);
            
        }else{
            
        }
    }
    public void DisplayExercises(){
        foreach(Exercise e in _exercises){
            System.Console.WriteLine($"{_exercises.IndexOf(e) + 1}. {e.GetSummary()}");
        }
    }
}