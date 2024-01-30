public class WritingAssignment : Assignment
{
    private string _title;


    public WritingAssignment(string studentname, string topic,
                             string title) : base(studentname, topic)
     {
        _title = title;

     }
    public string GetWritingInformation(){
        return $"{GetSummary()}\n{_title} ";
    }
}