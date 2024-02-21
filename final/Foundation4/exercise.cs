public abstract class Exercise
{
    protected int _length;
    protected string _date;


    public abstract void SetExercise();
    public abstract string GetSummary();

    public abstract double GetDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();
}