using System;

class Word
{
    private string _text;
    private string _hiddenText;
    private bool _isHidden;

    public string Text { get { return _text; } }
    public string HiddenText { get { return _hiddenText; } }
    public bool IsHidden { get { return _isHidden; } set { _isHidden = value; } }

    public Word(string text)
    {
        _text = text;
        _hiddenText = HideWord(text);
        _isHidden = false;
    }

    private string HideWord(string word)
    {
        string hiddenText = "";

        foreach (char c in word)
        {
            if (char.IsLetterOrDigit(c))
                hiddenText += "_";
            else
                hiddenText += c;
        }

        return hiddenText;
    }
}