public class Job
{
    public string _jobTitle;
    public string _company;
    public void JobDetails()
    {
        Console.WriteLine($"Job Title: {_jobTitle}");
        Console.WriteLine($"Company: {_company}");

    }
}