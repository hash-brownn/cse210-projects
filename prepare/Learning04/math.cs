public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentname, string topic,
                             string section, string problem) : base(studentname, topic)
     {
        _textbookSection = section;
        _problems = problem;
     }
    public string GetHomeWorkList(){
        return $"{GetSummary()}\n{_textbookSection} {_problems}";
    }
}