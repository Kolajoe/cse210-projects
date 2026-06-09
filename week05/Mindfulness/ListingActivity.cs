using System;
using System.Collections.Generic;
using System.Threading;
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private Random _random = new Random();
    public ListingActivity() : base("Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }
    protected override void RunActivity()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.Write("You will have a few seconds to think... ");
        PauseWithCountdown(5);

        Console.WriteLine("\nStart listing items (press Enter after each item). Type 'done' when finished (or time will end automatically):");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        PauseWithSpinner(3);
    }
}