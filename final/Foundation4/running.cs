public class Running : Exercise
{
    private double _distance;
    private string _type = "Running";

    public override void SetExercise()
    {
        Console.Write("How much distance (miles) did you ran?");
        _distance = double.Parse(Console.ReadLine());
        Console.Write("How long (in minutes) was your running session?");
        _length = int.Parse(Console.ReadLine());
        Console.Write("Date(xx/xx/xxxx):");
        _date = Console.ReadLine();
    }
    public override string GetSummary()
    {
         return $"{_date} {_type} ({_length} min) - Distance {GetDistance()} miles, Speed {CalculateSpeed()} mph, Pace {CalculatePace()} min per mile";
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (_distance / _length) * 60;
        speed = Math.Round(speed, 1);
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = 60 / CalculateSpeed();
        pace = Math.Round(pace, 1);
        return pace;
    }
}