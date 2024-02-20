public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;

    
    public ChecklistGoal(){

    }
    public ChecklistGoal(string name, string description, int points, int target, int completed) :base(name, description, points){
        _target = target;
        _amountCompleted = completed;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target){
            return true;
        }else{
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal,\"{_name}\",\"{_description}\",\"{_points}\",\"{_target}\",\"{_amountCompleted}\"";
    }

    public override string GetDetailsString()
    {
        if(IsComplete()){
            return $"[X] {_name} - {_description}({_amountCompleted}/{_target}) -- {_points} ";
        }else{
            return $"[ ] {_name} - {_description}({_amountCompleted}/{_target}) -- {_points}";
        }
    }
    public override void SetGoal() 
    {
        _amountCompleted = 0;
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("Give its short description: ");
        _description = Console.ReadLine();
        Console.Write("How many points is this goal worth? (be honest) ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("How many times do you want to accomplish this goal? ");
        _target = int.Parse(Console.ReadLine());
        

    }
}