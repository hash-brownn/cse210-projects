public class OutdoorGathering : Event
{
    private int _limit;
    private string _weather;

    public void SetEvent(){
        _type = "OutdoorGathering";
        SetStandardDetails();
         Console.Write("Describe weather Conditions? ");
        _weather = Console.ReadLine();
        Console.Write("What will be the limit of gathering? ");
        _limit = int.Parse(Console.ReadLine());
    }
    public override void FullDetails(){
        System.Console.WriteLine($"Type: OutDoor Gathering");
        StandardDetails();
        System.Console.WriteLine($"Limit: {_limit}");
        System.Console.WriteLine($"Weather: {_weather}");
        
    }
}