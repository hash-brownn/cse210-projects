public abstract class  Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;



    public abstract void FullDetails();
    public string Gettitle(){
        return _title;
    }
    
    protected void SetStandardDetails(){
        Console.Write("What is the title of Event? ");
        _title = Console.ReadLine();
        Console.Write("Give description of Event? ");
        _description = Console.ReadLine();
        Console.Write("What is the Scheduled Date of Event(xx/xx/xxxx)? ");
        _date = Console.ReadLine();
        Console.Write("At what time will the event start(e.g 5 am/pm? ");
        _time = Console.ReadLine();
        Console.Write("Write Address separated by commas(street,city,state,country): ");
        string[] parts = Console.ReadLine().Split(",");
        _address = new Address(parts[0],parts[1],parts[2],parts[3]);

    }
    public void StandardDetails(){
        System.Console.WriteLine($"Title: {_title}");
        System.Console.WriteLine($"Description: {_description}");
        System.Console.WriteLine($"Date: {_date}");
        System.Console.WriteLine($"Time: {_time}");
        System.Console.WriteLine($"Address: {_address.GetAddress()}");
    }
}