public class Verse{
    // I had to keep these attributes public so that when deserializing 
    // data from json I can easily put the corresponding values in the attributes
    // of this class. I couldn't find a way to do that with private attributes
    public string book { get; set; }
    public int chapter { get; set; }
    public int startVerse { get; set; }
    public int endVerse { get; set; }
    public string scripture { get; set; }

    public string GetVerse(){
        return scripture;
    }
    public Reference GetReference(){
        if (startVerse == endVerse)
        {
            Reference reference = new Reference(book, chapter, startVerse);
            return reference;
        }
        else{
            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            
            return reference;
        }
        
    }

}