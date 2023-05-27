using System;

class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        this._text = text;
        this._words = InitializeWords(text);
    }

    public void DisplayScripture(bool hideWords)
    {
        Console.Clear();
        Console.WriteLine("Scripture: " + _reference);
        Console.WriteLine();

        if (hideWords)
        {
            foreach (Word word in _words)
            {
                if (word.IsHidden)
                    Console.Write(word.HiddenText + " ");
                else
                    Console.Write(word.Text + " ");
            }
        }
        else
        {
            Console.WriteLine(_text);
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
    }

    public bool HideNextWords()
    {
        Random random = new Random();
        List<Word> remainingWords = GetRemainingWords();

        if (remainingWords.Count < 3)
            return false;

        List<Word> wordsToHide = new List<Word>();

        for (int i = 0; i < 3; i++)
        {
            int randomIndex = random.Next(0, remainingWords.Count);
            wordsToHide.Add(remainingWords[randomIndex]);
            remainingWords.RemoveAt(randomIndex);
        }

        foreach (Word word in wordsToHide)
        {
            word.IsHidden = true;
        }

        return true;
    }

    private List<Word> InitializeWords(string text)
    {
        string[] wordArray = text.Split(' ');
        List<Word> wordList = new List<Word>();

        foreach (string word in wordArray)
        {
            Word newWord = new Word(word);
            wordList.Add(newWord);
        }

        return wordList;
    }

    private List<Word> GetRemainingWords()
    {
        List<Word> remainingWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden)
                remainingWords.Add(word);
        }

        return remainingWords;
    }
}