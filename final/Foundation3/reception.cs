public class Reception : Event
{
    private string _rsvp;
    private string _registerForm;

    public void SetEvent(){
        _type = "Reception";
        SetStandardDetails();
         Console.Write("Write RSVP? ");
        _rsvp = Console.ReadLine();
        Console.Write("Give form document(form.pdf): ");
        _registerForm = Console.ReadLine();
    }
    public override void FullDetails(){
        System.Console.WriteLine($"Type: OutDoor Gathering");
        StandardDetails();
        System.Console.WriteLine($"RSVP: {_rsvp}");
        System.Console.WriteLine($"Register Form: {_registerForm}");
        
    }
}