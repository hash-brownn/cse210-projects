public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
       _word = text;
       _isHidden = false;
    }

    public void Hide()
    {
        if (_isHidden == false)
        {
            _isHidden = true;
        }
    }
    public bool IsHidden(){
        return _isHidden;
        
    }
    public void GetDisplayText()
    {
        // The following code makes sure that only letter words get hidden
        // and other non-letter characters like comma(,), semi-colon(;) and verse
        // number (12) etc stay unhidden.
        if (_isHidden == true)
        {
            foreach (char c in _word)
            {
                if (!char.IsLetter(c))
                {
                    Console.Write(c);
                }
                else{
                    Console.Write('-');
                }
                
            }
            Console.Write(" ");

        }
        else
        {
            Console.Write($"{_word} ");
        }
    }


}