public class Entry
{
    public string _dateText;
    public string _prompt;
    public string _body;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_dateText} - {_prompt}");
        Console.WriteLine(_body);
    }

}
