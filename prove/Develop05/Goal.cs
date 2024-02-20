using System.Drawing;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;


    public Goal(){

    }
    public Goal(string name, string description, int points){
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName(){
        return _name;
    }
    public int GetPoints(){
        return _points;
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract void SetGoal();

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();


}