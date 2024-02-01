public class Breathing  : Activity
{
    public Breathing() 
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run(){
        DateTime futuretime = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < futuretime){
            System.Console.WriteLine();
            System.Console.WriteLine();
            Console.Write("Breathe in.. ");
            CountDown(4);
            System.Console.WriteLine();
            Console.Write("Breathe out.. ");
            CountDown(6);
        }
    }



}