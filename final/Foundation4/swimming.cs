public class Swimming : Exercise
{
    private string _type = "Swimming";
    private int _laps;

    public override void SetExercise()
    {
        Console.Write("How many laps did you finish?");
        _laps = int.Parse(Console.ReadLine());
        Console.Write("How long (in minutes) was your swimming session?");
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
        double Distance = _laps * 50 / 1000 * 0.62;
        Distance = Math.Round(Distance, 1);
        return Distance;

    }
    public override double CalculateSpeed()
    {
        double speed = (GetDistance() / _length) * 60;
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