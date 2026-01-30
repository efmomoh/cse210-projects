using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");

        // let's instantiate the video object
        // video one
        Video video1 = new Video("Leraning C#", "BYU-Idaho", 300);
        video1.AddComment(new Comment("Enssah", "Great explanation!"));
        video1.AddComment(new Comment("Fayia", "Very helpful."));
        video1.AddComment(new Comment("Momoh", "I finally understand abstraction."));

        // video two 
        Video video2 = new Video("OOP Basics", "TechWorld", 420);
        video2.AddComment(new Comment("Princess", "Clear and simple.")); 
        video2.AddComment(new Comment("Chemist Momoh", "Love the examples."));
        video2.AddComment(new Comment("Reading", "Please make more videos."));
        
        // video three
        Video video3 = new Video("Why Learning Programming?", "CodeHub", 180);
        video3.AddComment(new Comment("Taurus", "Motivating content."));
        video3.AddComment(new Comment("Don", "This inspired me."));
        video3.AddComment(new Comment("Jesus Matters Most", "Well said."));

        // create a list and store videos in a list 
        List<Video> videos = new List<Video>
        {
            video1, video2, video3
        };

        // let's use a foreach loop to loop over each video and display the videos
        foreach(Video video in videos)
        {
            video.DisplayVideoInformation();
        }

       
    }
}