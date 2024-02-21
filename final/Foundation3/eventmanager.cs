public class EventManager
{
    private List<Event> _events = new List<Event>();
    public void Start(){
        bool runloop = true;
        while(runloop){
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("---Publish your events and get information on other's---");
            System.Console.WriteLine("1. Create Event.");
            System.Console.WriteLine("2. Available Events.");
            System.Console.WriteLine("3. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch(choice){
                case "1":
                    Console.Clear();
                    CreateEvent();
                    break;
                case "2":
                    Console.Clear();
                    DisplayEvents();
                    DisplayOneEvent();
                    break;
                case "3":
                    runloop = false;
                    break;
                default:
                    break;    

            }
        }
    }
    public void CreateEvent(){
        System.Console.WriteLine("Which type of Event do you want to create:");
        System.Console.WriteLine("1. Lecture Event");
        System.Console.WriteLine("2. OutDoor Gathering Event");
        System.Console.WriteLine("3. Reception Event");
        Console.Write("Select an Event Type: ");
        string goalchoice = Console.ReadLine();
        if (goalchoice == "1"){
            Lecture lecture = new Lecture();
            lecture.SetEvent();
            _events.Add(lecture);

        }else if(goalchoice == "2"){
            OutdoorGathering outdoor = new OutdoorGathering();
            outdoor.SetEvent();
            _events.Add(outdoor);
        }else if(goalchoice == "3"){
            Reception reception = new Reception();
            reception.SetEvent();
            _events.Add(reception);
            
        }else{
            
        }
    }

    public void DisplayEvents(){
        
        foreach(Event e in _events){
            System.Console.WriteLine($"{_events.IndexOf(e) + 1}. {e.Gettitle()}");
        }
    }
    public void DisplayOneEvent(){
        Console.Write("Which Event Do you want to pick?");
        int Index = int.Parse(Console.ReadLine()) - 1;
        Console.Clear();
        _events[Index].FullDetails();
        Console.ReadLine();
    }
}