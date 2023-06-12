using System;

public class ListingActivity : Activity
{
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    public ListingActivity(string name, int duration) : base(name, duration)
    {

    }

    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void Listing(int seconds)
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int promptIndex = random.Next(prompts.Count);

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {prompts[promptIndex]} --- ");
        CountDown();
        Console.WriteLine();
        RunStopwatch(seconds);
    }
}