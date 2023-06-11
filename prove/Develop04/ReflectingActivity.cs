using System;

public class ReflectingActivity : Activity
{
    private string _description = "This activity will guide you through reflection. Answer the provided prompts and take a moment to reflect on your thoughts and emotions.";

    public ReflectingActivity(string name, int duration) : base(name, duration)
    {

    }

    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void Reflecting(int seconds)
    {
        int secondsTimer = 0;

        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random random = new Random();
        int promptIndex = random.Next(prompts.Count);

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" ---{prompts[promptIndex]}--- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        CountDown();
        Console.Clear();

        while (secondsTimer < seconds)
        {
            for (int i = 0; i < seconds;)
            {
                int questionIndex = random.Next(questions.Count);
                Console.Write($"> {questions[questionIndex]} -------------------- ");
                for (float j = 0; j < 20; j++)
                {
                    Console.Write("\b\b ");
                    Thread.Sleep(500);
                }
                //Thread.Sleep(10000); // DURCH SPINNER ERSETZEN
                secondsTimer += 10;
                i += 10;
                Console.WriteLine();
            }
        }
    }
}