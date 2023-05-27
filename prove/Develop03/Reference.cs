using System;

class Reference
{
    public string Text { get; }

    // public Reference(string text)
    // {
    //     Text = text;
    // }

    public Reference(string book, int chapter, int verse)
    {
        Text = $"{book} {chapter}:{verse}";
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Text = $"{book} {chapter}:{startVerse}-{endVerse}";
    }

    public override string ToString()
    {
        return Text;
    }
}