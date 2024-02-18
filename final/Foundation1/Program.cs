using System;

class Program
{
    static void Main(string[] args)
    {
        //Video1
        Video video1 = new Video("My home", "David", 200);
        video1.AddComment(new Comment("Rico", "Pretty House"));
        video1.AddComment(new Comment("Peen", "Love your home"));
        video1.AddComment(new Comment("Riza", "Such a good house."));

        //Video2
        Video video2 = new Video("My Cow", "David", 100);
        video2.AddComment(new Comment("Rico", "Pretty cow"));
        video2.AddComment(new Comment("Peen", "Love your cow"));
        video2.AddComment(new Comment("Riza", "Such a good cow."));

        //Video3
        Video video3 = new Video("My sofa", "David", 300);
        video3.AddComment(new Comment("Rico", "Pretty sofa"));
        video3.AddComment(new Comment("Peen", "Love your sofa"));
        video3.AddComment(new Comment("Riza", "Such a good sofa."));


        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        bool exit = false;

        while(!exit){
            Console.Clear();
            foreach(Video video in videos){
                System.Console.WriteLine($"{videos.IndexOf(video) + 1}. {video.ShortDescription()}");
                

               
        }
            Console.Write("Pick video (type 0 to exit):");
            int choice = int.Parse(Console.ReadLine());
            if (choice!= 0 && choice <= videos.Count){

                        Console.Clear();
                        videos[choice - 1].DisplayVideoInfo();
                        Console.ReadLine();
                    }
                    else{
                        exit = true;
                    }
            }
        
    }
}