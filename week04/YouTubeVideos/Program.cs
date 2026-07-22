using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Lego Star Wars, New sets sneak peak", "BrickMaster", 5200);
        video1.Comments.Add(new Comment("Lego_fan22", "I love the new releases, looking forward to them!"));
        video1.Comments.Add(new Comment("Brick Dude", "I just wish the prices weren't so high..."));
        video1.Comments.Add(new Comment("Nick12", "Can't wait to add them to my collection!"));
        videoList.Add(video1);

        Video video2 = new Video("Mountain Dew Brownies", "Mountain Dude", 7300);
        video2.Comments.Add(new Comment("Dew_Lover", "Where have these been my whole life!"));
        video2.Comments.Add(new Comment("Christopher Robins", "I never though Pooh would like something more than honey!"));
        video2.Comments.Add(new Comment("LaFonda", "They were meh"));
        videoList.Add(video2);

        Video video3 = new Video("Gaming PC 101", "TechGuy", 2000);
        video3.Comments.Add(new Comment("Nerd_Alert", "This is super helpful!"));
        video3.Comments.Add(new Comment("Earl Watts", "I still can't get mine to work?"));
        video3.Comments.Add(new Comment("GamerGal34", "I love your content!"));
        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            Console.WriteLine("===================================================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: \"{comment.Text}\"");
            }
            Console.WriteLine();
        }
    }
}