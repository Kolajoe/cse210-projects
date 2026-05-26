using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // EXCEEDING REQUIREMENTS:
        // Library of several scripts (random choice)
        // Mix of scripts to present to the user
        // Choose only words not yet hidden
        // Display a remaining word counter

        Scripture[] library = new Scripture[]
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only Son, so that whoever believes in him shall not perish, but have eternal life."),
            new Scripture(new Reference ("Proverbs", 3, 6), "Trust in the Lord with all your heart, and do not rely on your own understanding. Acknowledge him in all your ways, and he will make your paths straight."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through him who strengthens me."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd: I shall not want.")
        };
        Random rand = new Random();
        Scripture scripture = library[rand.Next(library.Length)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\n\nPress ENTER to hide more words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
               break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\n\nAll the words are hidden! End of program.");
                break;
            }
        }
    }
}