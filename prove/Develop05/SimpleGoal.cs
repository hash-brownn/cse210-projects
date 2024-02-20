public class SimpleGoal : Goal
{
    private bool _iscomplete;


    public SimpleGoal(){

    }
    public SimpleGoal(string name, string description, int points, bool iscomplete) : base(name, description, points){
        _iscomplete = iscomplete;
    }
    public override void RecordEvent()
    {
        _iscomplete = true;
    }

    public override bool IsComplete()
    {
        return _iscomplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,\"{_name}\",\"{_description}\",\"{_points}\",\"{IsComplete()}\"";
    }
    public override string GetDetailsString()
    {
           if(IsComplete()){
            return $"[X] {_name} - {_description} -- {_points}";
        }else{
            return $"[ ] {_name} - {_description} -- {_points}";
        }
    }
    public override void SetGoal() 
    {
        _iscomplete = false;
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("Give its short description: ");
        _description = Console.ReadLine();
        Console.Write("How many points is this goal worth? (be honest) ");
        _points = int.Parse(Console.ReadLine());
        

    }


}