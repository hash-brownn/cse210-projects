public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text){
        _reference = reference;

       

       // spliting the string verse into an array of words based of the spaces
       // between them
        string[] array = text.Split(' ');
        foreach (string w in array)
        {
            Word word = new Word(w);
            _words.Add(word);
        }   

    

    }
    public void GetDisplayScripture()
    {
        _reference.GetDisplayReference();
        foreach (Word word in _words){
            word.GetDisplayText();
        }

    }
    public void HideRandomWords(int numbertoHide){
        Random random = new Random();

        // this loop will itereate 'numbertoHide' times so that 'numbertoHide'
        // number of words are hidden in each enter
        for (int i = 0; i < numbertoHide; i++)
        {

            // This following code makes sure that an unhidden word is always selected to 
            // be hidden
            List<int> unhiddenIndices = new List<int>();

        // this loop will iterate through all of the words in the given verse
            for (int index = 0; index < _words.Count; index++)
            {
                // and then see which one are not hidden
                if (!_words[index].IsHidden())
                {
                    // and then will put the indices of all the unhidden words in 
                    // the list 'unhiddenIndices' defined above
                    unhiddenIndices.Add(index);
                }
            }

            if (unhiddenIndices.Count == 0)
            {
                break;
            }
            // this line will take a random number between 0 and the number of 
            // unhiddenIndices
            int randomNumber = random.Next(unhiddenIndices.Count);

            // This line will take the value that is in unhiddenIndices at the index
            // randomNumber
            int randomIndex = unhiddenIndices[randomNumber];

            // this line will then hide the word that is at that index
            // which is randomly extracted from the unhiddenIndices
            _words[randomIndex].Hide();
            
            

        }
    }

    public bool IscompletelyHidden(){
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }

        }
        return true;
    }
}
