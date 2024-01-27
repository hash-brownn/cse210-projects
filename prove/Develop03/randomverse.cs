using System.Diagnostics;
using System.Text.Json;

public class RandomVerse{
    private List<Verse> _verses = new List<Verse>();
    private Verse _verse;

    public void RandomizeVerse(string file)
    {
        //extracting data from Json file
       using (StreamReader r = new StreamReader(file))  
            {  
                string json = r.ReadToEnd();  
                _verses = JsonSerializer.Deserialize<List<Verse>>(json);  
            }  

        // picking a random verse from the list of verses
        Random random = new Random();
        int randomNumber = random.Next(0, _verses.Count);
        _verse = _verses[randomNumber];
    }  

    
    public string GetVerse(){
        return _verse.GetVerse();
    }

    public Reference GetReference()
    {
        return _verse.GetReference();
    }

}