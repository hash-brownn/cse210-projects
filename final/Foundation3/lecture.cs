public class Lecture : Event
{
    private string _speaker;
    private int _capacity;



    public void SetEvent(){
        _type = "Lecture";
        SetStandardDetails();
         Console.Write("Who will be the speaker of Event? ");
        _speaker = Console.ReadLine();
        Console.Write("What will be the capacity of gathering? ");
        _capacity = int.Parse(Console.ReadLine());
    }
    public override void FullDetails(){
        System.Console.WriteLine($"Type: Lecture");
        System.Console.WriteLine($"Speaker: {_speaker}");
        System.Console.WriteLine($"Capacity: {_capacity}");
        StandardDetails();
    }
}