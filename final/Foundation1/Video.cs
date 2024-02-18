public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment){
        _comments.Add(comment);
    }
    public void DisplayComments(){
        foreach(Comment comment in _comments){
            comment.DisplayComment();
        }
    }
    public string ShortDescription(){
        return $"{_title} - {_author}";
    }
    public void DisplayVideoInfo(){
        System.Console.WriteLine($"{_title} - {_author} ({_length}s)");
        System.Console.WriteLine("----------");
        System.Console.WriteLine("Comments");
        System.Console.WriteLine("----------");
        DisplayComments();

    }
}