using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create and add videos
        Video video1 = new Video
        {
            Title = "The Parable of the Slope | Elder Clark G. Gilbert",
            Author = "The Church of Jesus Christ of Latter-day Saints",
            Length = 325
        };
        videos.Add(video1);

        // Add 3 comments to video 1
        video1.AddComment(new Comment {CommenterName = "benjamintingey8516", CommentText = "Beautiful message and artistry. Loved this line: 'He will do everything He can to help us turn our slopes toward heaven.'"});
        video1.AddComment(new Comment {CommenterName = "jcustard", CommentText = "I really love this. Please share talent like this more often. It amplifies Gospel messages in such a striking way! Thank you for making my day."});
        video1.AddComment(new Comment {CommenterName = "scottsoward", CommentText = "Christ can lift us from wherever we are... What an important message, and so beautifully illustrated." });

        Video video2 = new Video
        {
            Title = "Angels in the Mirror",
            Author = "The Church of Jesus Christ of Latter-day Saints",
            Length = 346
        };
        videos.Add(video2);

        // Add 4 comments to video 2
        video2.AddComment(new Comment {CommenterName = "mehtafamily2542", CommentText = "When he said that Monica was his wife I smiled real big. I don't know why but it just made me smile. Happy for them."});
        video2.AddComment(new Comment {CommenterName = "josevivas953", CommentText = "What an incredible and inspiring message. Thank you. Thank you for reminding me of my worth and responsibility of helping others in and outside the church."});
        video2.AddComment(new Comment {CommenterName = "alishametiam8025", CommentText = "I am inspired by Elder Godoy's story. Indeed, our kindness is needed."});
        video2.AddComment(new Comment {CommenterName = "joseflores-mz2rl", CommentText = "Beautiful! ♥Thank you for posting this. It touched my heart."});

        Video video3 = new Video
        {
            Title = "The Other Prodigal Son",
            Author = "The Church of Jesus Christ of Latter-day Saints",
            Length = 369
        };
        videos.Add(video3);

        // Add 3 comments to video 3
        video3.AddComment(new Comment {CommenterName = "shaniaa.1397", CommentText = "'The green-eyed monster of jealousy' This parable teaches on how to overcome it. And love others as Christ loves us ♥"});
        video3.AddComment(new Comment {CommenterName = "scottcampbell8299", CommentText = "Thank you, Brother Holland, for putting your voice to this wonderful message. Truly a video many can learn from too."});
        video3.AddComment(new Comment {CommenterName = "shadjohnsen", CommentText = "What a great message to help heal family issues by allowing our hearts to heal!"});

        Console.Clear();
        Console.WriteLine("********************************************************************************");

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title: <{video.Title}>");
            Console.WriteLine($"Author: <{video.Author}>");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- Commenter: <{comment.CommenterName}>");
                Console.WriteLine($"- Comment: <{comment.CommentText}>");
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}
