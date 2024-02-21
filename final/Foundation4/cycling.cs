public class Cycling : Exercise
{
    private double _speed;
    private string _type = "Cycling";

    public override void SetExercise()
    {
        Console.Write("At what speed (mph) did you cycled at?");
        _speed = double.Parse(Console.ReadLine());
        Console.Write("How long (in minutes) was your cycling session?");
        _length = int.Parse(Console.ReadLine());
        Console.Write("Date(xx/xx/xxxx):");
        _date = Console.ReadLine();
    }
    public override string GetSummary()
    {
        return $"{_date} {_type} ({_length} min) - Distance {GetDistance()} miles, Speed {CalculateSpeed()} mph, Pace {CalculatePace()} min per mile";
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        double distance = (CalculateSpeed() / 60) * _length;
        distance = Math.Round(distance, 1);
        return distance;
    }
    public override double CalculatePace()
    {
        double pace = 60 / CalculateSpeed();
        pace = Math.Round(pace, 1);
        return pace;
    }
}