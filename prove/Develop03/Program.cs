// In order to exceed the requirements, I added multiple scriptures that are handled
// by the reference class and the scripture class to be added to an array. From the array,
// the program chooses a random scripture to then execute the program with.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference _reference1 = new Reference("John", 3, 16);
        Reference _reference2 = new Reference("Proverbs", 3, 5, 6);
        Reference _reference3 = new Reference("Moses", 1, 39);
        Reference _reference4 = new Reference("Psalm", 24, 3, 4);
        Reference _reference5 = new Reference("Matthew", 16, 15, 19);

        Scripture _scripture1 = new Scripture(_reference1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Scripture _scripture2 = new Scripture(_reference2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Scripture _scripture3 = new Scripture(_reference3, "For behold, this is my work and my glory — to bring to pass the immortality and eternal life of man.");
        Scripture _scripture4 = new Scripture(_reference4, "Who shall ascend into the hill of the Lord? or who shall stand in his holy place? He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully.");
        Scripture _scripture5 = new Scripture(_reference5, "He saith unto them, But whom say aye that I am? And Simon Peter answered and said, Thou art the Christ, the Son of the living God. And Jesus answered and said unto him, Blessed art thou, Simon Bar-jona: for flesh and blood hath not revealed it unto thee, but my Father which is in heaven. And I say also unto thee, That thou art Peter, and upon this rock I will build my church; and the gates of hell shall not prevail against it. And I will give unto thee the keys of the kingdom of heaven: and whatsoever thou shalt bind on earth shall be bound in heaven: and whatsoever thou shalt loose on earth shall be loosed in heaven.");

        Scripture[] _scriptures = { _scripture1, _scripture2, _scripture3, _scripture4, _scripture5 };

        Random _random = new Random();
        int _randomIndex = _random.Next(0, _scriptures.Length);
        Scripture _selectedScripture = _scriptures[_randomIndex];

        string _userInput = "";
        bool _hideWords = false;

        do
        {
            _selectedScripture.DisplayScripture(_hideWords);
            _userInput = Console.ReadLine();

            if (_userInput == "quit")
                break;

            _hideWords = _selectedScripture.HideNextWords();
        }
        while (_hideWords);

        Console.WriteLine("Program ended. Press any key to exit.");
        Console.ReadKey();
    }
}