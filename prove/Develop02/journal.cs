public class Journal
{
    public string _fileName;
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }


    public void SaveToFile(string file)
    {
        _fileName = file;
    
       using (StreamWriter OutputFile = new StreamWriter(file)) 
       {
        OutputFile.WriteLine("Date , Prompt, Thoughts");
        foreach (Entry e in _entries)
        {
            // putting \" so that the values can be separated by comma
            OutputFile.WriteLine($"{e._dateText},\"{e._prompt}\",\"{e._body}\"");

        }
       }
    
    }

    public void LoadingJournal(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))

        {
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                // Split the line into fields based on the comma 
                string[] fields = line.Split(',');

                string[] parts = line.Split(",\"");

                // making entry object and putting values from the splited row
                // in it
                Entry entry = new Entry();
                entry._dateText = fields[0];
                entry._prompt = parts[1].Trim('\"');
                entry._body = parts[2].Trim('\"'); 

                _fileName = file;
                _entries.Add(entry);

             
            }
        }
        

        
    }
    
    public void DisplayJournal()
    {
        foreach(Entry e in _entries)
        {
            Console.WriteLine("---------------");
            e.DisplayEntry();
        }
    }


    public void DeleteEntry(int entryToDelete)
    {
        _entries.RemoveAt(entryToDelete - 1);
    }

}