using System;

public class JournalEntry
{
    public string _prompt;
    public string _answer;
    public string _mood;
    public DateTime _dateTime;

    public JournalEntry(string _prompt, string _answer, string _mood, DateTime _dateTime)
    {
        this._prompt = _prompt;
        this._answer = _answer;
        this._mood = _mood;
        this._dateTime = _dateTime;
    }

    public override string ToString()
    {
        return $"{_dateTime.ToString("g")}~{_prompt}~{_answer}~Mood: {_mood}";
    }
}