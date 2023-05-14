using System;
using System.IO;

public class Journal
{
    public JournalEntry[] _entries;
    public PromptGenerator _promptGenerator;
    public QuoteGenerator _quoteGenerator;
    public Journal()
    {
        _promptGenerator = new PromptGenerator();
        _quoteGenerator = new QuoteGenerator();
        _entries = new JournalEntry[0];
    }
    
    public void WriteEntry()
    {
        Console.WriteLine("\nHere's your prompt for today:");
        string _prompt = _promptGenerator.GeneratePrompt();
        DateTime _currentDate = DateTime.Now;
        Console.Write($"{_currentDate.ToString("g")} | {_prompt}\n> ");
        string _answer = Console.ReadLine();
        Console.Write("How are you feeling right now?\n> ");
        string _mood = Console.ReadLine();

        JournalEntry _newEntry = new JournalEntry(_prompt, _answer, _mood, _currentDate);
        Array.Resize(ref _entries, _entries.Length + 1);
        _entries[_entries.Length - 1] = _newEntry;

        Console.WriteLine("\nHere's something to inspire you:");
        string _quote = _quoteGenerator.GenerateQuote();
        Console.WriteLine($"   '{_quote}'");
    }

    public void DisplayEntries()
    {
        if (_entries.Length == 0)
        {
            Console.WriteLine("\nNo entries found.");
        }

        else
        {
            Console.WriteLine("\nYour entries so far:");
            foreach (JournalEntry entry in _entries)
            {
                string _splitEntry = entry.ToString();
                string[] _splitEntries = _splitEntry.Split('~');
                Console.WriteLine($"{_splitEntries[0]} | {_splitEntries[1]}\n> {_splitEntries[2]}\n{_splitEntries[3]}\n");
            }
        }
    }

    public void LoadEntries()
    {
        Array.Clear(_entries, 0, _entries.Length);
        Console.Write("What is the filename? (enter as filename.txt)\n>");
        string _filename = Console.ReadLine();
        Console.WriteLine("Loading from file...");
        string[] _lines = System.IO.File.ReadAllLines(_filename);
        
        if (_lines.Length == 0)
        {
            Console.WriteLine("\nNo entries found.");
            return;
        }

        else
        {
            foreach (string line in _lines)
            {
                string[] _parts = line.Split("~");

                DateTime _currentDate = DateTime.Parse(_parts[0]);
                string _prompt = _parts[1];
                string _answer = _parts[2];
                string _mood = _parts[3];

                JournalEntry _newEntry = new JournalEntry(_prompt, _answer, _mood, _currentDate);
                Array.Resize(ref _entries, _entries.Length + 1);
                _entries[_entries.Length - 1] = _newEntry;            
            }

            Console.WriteLine("Entries loaded");
        }
    }

    public void SaveEntries()
    {
        if (_entries.Length == 0)
        {
            Console.WriteLine("\nNo entries found that can be saved.");
        }
        
        else
        {
            Console.Write("What is the filename? (enter as filename.txt)\n>");
            string _filename = Console.ReadLine();
            Console.WriteLine("Saving to file...");
            using (StreamWriter _outputFile = new StreamWriter(_filename))
            {
                foreach (JournalEntry entry in _entries)
                {
                    _outputFile.WriteLine(entry);
                }
            }
            Console.WriteLine("Saved");
        }
    }
}