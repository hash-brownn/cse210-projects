public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    // Constructors 

    // to make the reference object having a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;

    }
    // to make reference object having multiple verses
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;

    }

    public void GetDisplayReference()
    {
        if (_endVerse == 0)
        {
            Console.Write($"{_book} {_chapter}:{_verse}: ");
        }
        else{
            Console.Write($"{_book} {_chapter}:{_verse}-{_endVerse}:");
        }
    }

}