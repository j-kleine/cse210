using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create and add videos
        Video video1 = new Video("The Parable of the Slope | Elder Clark G. Gilbert", "The Church of Jesus Christ of Latter-day Saints", 325);
        videos.Add(video1);

        // Add 3 comments to video 1
        Comment comment1_1 = new Comment("benjamintingey8516", "Beautiful message and artistry. Loved this line: 'He will do everything He can to help us turn our slopes toward heaven.'");
        video1.AddComment(comment1_1);
        Comment comment1_2 = new Comment("jcustard", "I really love this. Please share talent like this more often. It amplifies Gospel messages in such a striking way! Thank you for making my day.");
        video1.AddComment(comment1_2);
        Comment comment1_3 = new Comment("scottsoward", "Christ can lift us from wherever we are... What an important message, and so beautifully illustrated.");
        video1.AddComment(comment1_3);

        Video video2 = new Video("Angels in the Mirror", "The Church of Jesus Christ of Latter-day Saints", 346);
        videos.Add(video2);

        // Add 4 comments to video 2
        Comment comment2_1 = new Comment("mehtafamily2542", "When he said that Monica was his wife I smiled real big. I don't know why but it just made me smile. Happy for them.");
        video2.AddComment(comment2_1);
        Comment comment2_2 = new Comment("josevivas953", "What an incredible and inspiring message. Thank you. Thank you for reminding me of my worth and responsibility of helping others in and outside the church.");
        video2.AddComment(comment2_2);
        Comment comment2_3 = new Comment("alishametiam8025", "I am inspired by Elder Godoy's story. Indeed, our kindness is needed.");
        video2.AddComment(comment2_3);
        Comment comment2_4 = new Comment("joseflores-mz2rl", "Beautiful! ♥Thank you for posting this. It touched my heart.");
        video2.AddComment(comment2_4);

        Video video3 = new Video("The Other Prodigal Son", "The Church of Jesus Christ of Latter-day Saints", 369);
        videos.Add(video3);

        // Add 3 comments to video 3
        Comment comment3_1 = new Comment("shaniaa.1397", "'The green-eyed monster of jealousy' This parable teaches on how to overcome it. And love others as Christ loves us ♥");
        video3.AddComment(comment3_1);
        Comment comment3_2 = new Comment("scottcampbell8299", "Thank you, Brother Holland, for putting your voice to this wonderful message. Truly a video many can learn from too.");
        video3.AddComment(comment3_2);
        Comment comment3_3 = new Comment("shadjohnsen", "What a great message to help heal family issues by allowing our hearts to heal!");
        video3.AddComment(comment3_3);

        Console.Clear();
        Console.WriteLine("********************************************************************************");

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title: <{video.GetTitle()}>");
            Console.WriteLine($"Author: <{video.GetAuthor()}>");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- Commenter: <{comment.GetCommenterName()}>");
                Console.WriteLine($"- Comment: <{comment.GetCommentText()}>");
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}
