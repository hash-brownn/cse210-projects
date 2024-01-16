using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        

         // Job 1
        Job webdev = new Job();
        webdev._jobTitle = "Front-end developer";
        webdev._company = "Apple";


        // job 2
        Job teacher = new Job();
        teacher._jobTitle = "Maths Teacher";
        teacher._company = "School of sciences";


        

        Console.WriteLine("Resume!!!");

        Resume myresume = new Resume();
        myresume._name = "Hasheem";
        myresume._Jobs.Add(teacher);
        myresume._Jobs.Add(webdev);
        
        myresume._highestQualification = "Computer Science";
        myresume.ResumeDetails();



        //Console.WriteLine(myresume._appliedJobs[0]._jobTitle);



       
    }
}


