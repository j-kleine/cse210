using System;

public class QuoteGenerator
{
    public string[] _quotes = {
        "Believe you can and you're halfway there. -Theodore Roosevelt",
        "You miss 100% of the shots you don't take. -Wayne Gretzky",
        "It does not matter how slowly you go as long as you do not stop. -Confucius",
        "Success is not final, failure is not fatal: it is the courage to continue that counts. -Winston Churchill",
        "The only way to do great work is to love what you do. -Steve Jobs"
    };

    public Random _random;

    public QuoteGenerator()
    {
        _random = new Random();
    }

    public string GenerateQuote()
    {
        int randomNumber = _random.Next(0, _quotes.Length);
        return _quotes[randomNumber];
    }
}