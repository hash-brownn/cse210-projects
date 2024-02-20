public class EternalGoal : Goal
{

    public EternalGoal(){

    }
    public EternalGoal(string name, string description, int points):base(name, description, points){

    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,\"{_name}\",\"{_description}\",\"{_points}\"";
    }
    public override string GetDetailsString()
    {
        return $"[Eternal Goal] {_name} - {_description}. --- {_points}";
    }
    public override void SetGoal() 
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("Give its short description: ");
        _description = Console.ReadLine();
        _points = 10;

    }
}