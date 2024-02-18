public class Comment
{
    public string _user;
    public string _text;

    public Comment(string user, string text)
    {
        _user = user;
        _text = text;
    }
    public void DisplayComment(){
        System.Console.WriteLine($"{_user} - {_text}");
    }

}