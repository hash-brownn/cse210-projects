public class Prompt
{
    // list of prompts
    public List<string> _prompts = new List<string> {"Did today felt productive? How so?", 
        "What is the favorite memory of today for you?", 
        "If you could redo one thing from today, what that might be?",
        "What is your hope for tomorrow?", 
        "Were there any unexpected surprises or challenges that came up today?",
        "What is something new or different that you learned today?",
        "If you had a soundtrack for your day, what songs would be on it?",
        "Did you encounter any funny or interesting moments today that stood out?",
        "Is there a specific goal or task you're looking forward to tackling tomorrow?",
        "Tell me about a conversation you had today that made an impact on you?"};


// choosing a random prompt from the list
    public string PromptGenerator()
    {

        Random random = new Random();

        // next function makes that the random is always 
        //different and never comes to be the same
        int RandomNumber = random.Next(0, _prompts.Count);

        string prompt = _prompts[RandomNumber];

        return prompt;
    }
}