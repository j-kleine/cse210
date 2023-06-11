using System;

public class Activity
{
    private string _name;
    private int _duration;
    private string _messageBegin = "You may begin in:";

    public Activity(string name, int duration)
    {
        _name = name;
        _duration = duration;
    }

    public void GetActivityName()
    {
         Console.WriteLine($"Welcome to the {_name} Activity\n");
    }
    // public void SetActivityName(string name)
    // {
    //     _name = name;
    // }

    public int GetDuration()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int durationInput = Int32.Parse(Console.ReadLine());
        _duration = durationInput;

        return durationInput;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        for (int i = 0; i <= 20; i++)
        {
            Console.Write($"\r{spinner[index]}");
            index = (index + 1) % spinner.Length;
            Thread.Sleep(100);
        }
        Console.Write($"\r ");
    }

    public void GetDone()
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        
        Console.WriteLine("\n");
        Console.WriteLine("Well Done!");

        for (int i = 0; i <= 20; i++)
        {
            Console.Write($"\r{spinner[index]}");
            index = (index + 1) % spinner.Length;
            Thread.Sleep(100);
        }
        Console.Write($"\r");
        Console.WriteLine();

        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");

        for (int i = 0; i <= 20; i++)
        {
            Console.Write($"\r{spinner[index]}");
            index = (index + 1) % spinner.Length;
            Thread.Sleep(100);
        }
        Console.Clear();
    }

    public void CountDown()
    {
        for (int i = 3; i >= 0; i--)
        {
            Console.Write($"\r{_messageBegin} {i}");
            Thread.Sleep(1000);
        }
    }
}