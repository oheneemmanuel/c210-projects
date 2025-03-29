using System;



class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("learn CSS", "Bro COde",3, new List<Comment>());
        video1.AddComment(new Comment("Alice", "Nice Video very helpful"));
        video1.AddComment(new Comment("Charlie", "Excited to try it out!"));

        Video video2 = new Video("Learn Python", "John Smith", 4,  new List<Comment>() );
        video2.AddComment(new Comment("Jordan", "Very easy to understand."));
        video2.AddComment(new Comment("Chris", "Loved the examples!"));

     
        Video video3 = new Video("Top 10 Movies of 2025", "Cinephile Studios", 7, new List<Comment>());
        video3.AddComment(new Comment("Sam", "Loved the recommendations!"));
        video3.AddComment(new Comment("Mia", "What about horror movies?"));


        Video video4 = new Video("Beginner's Guide to Gardening", "Green Fingers Channel", 600, new List<Comment>());
        video4.AddComment(new Comment("Alice", "This was super helpful!"));
        video4.AddComment(new Comment("Bob", "Loved the tips on soil preparation!"));





        List<Video> videos = new List<Video> { video1, video2, video3, video4 };
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}   