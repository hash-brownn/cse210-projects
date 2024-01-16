public class Resume
{
    public string _name;
    public string _highestQualification;

    public List<Job> _Jobs = new List<Job>();

    public void ResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Qualification: {_highestQualification}");
        Console.WriteLine("Worked At:");
        foreach (Job _job in _Jobs)
        {
            Console.WriteLine("----------");
            _job.JobDetails();
            
        }
    }

}