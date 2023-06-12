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
    public void SetActivityName(string name)
    {
        _name = name;
    }

    public int GetDuration()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int durationInput = Int32.Parse(Console.ReadLine());
        _duration = durationInput;
        Console.Clear();

        return durationInput;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    string[] _spinner = { "|", "/", "-", "\\" };
    int _index = 0;

    public void GetReady()
    {
        //Console.Clear();
        Console.WriteLine("Get ready...");
        
        for (int i = 0; i <= 20; i++)
        {
            Console.Write($"\r{_spinner[_index]}");
            _index = (_index + 1) % _spinner.Length;
            Thread.Sleep(100);
        }
        Console.Write($"\r ");
    }

    public void GetDone()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Well Done!");

        for (int i = 0; i <= 20; i++)
        {
            Console.Write($"\r{_spinner[_index]}");
            _index = (_index + 1) % _spinner.Length;
            Thread.Sleep(100);
        }
        Console.Write($"\r ");
        Console.WriteLine();

        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");

        for (int i = 0; i <= 20; i++)
        {
            Console.Write($"\r{_spinner[_index]}");
            _index = (_index + 1) % _spinner.Length;
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
        Console.Write($"\r{_messageBegin} ");
    }

    public void RunStopwatch(int seconds)
    {
        int _responseCounter = 0;
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(seconds);

        while (DateTime.Now < _endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _responseCounter = (_responseCounter + 1);
        }

        Console.WriteLine($"You listed {_responseCounter} items!");
        Thread.Sleep(1000);
    }
}