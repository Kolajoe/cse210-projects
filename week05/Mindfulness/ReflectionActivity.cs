using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private Random _random = new Random();
    private List<string> _unusedQuestions;
    public ReflectionActivity() : base("Reflection",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        ResetUnusedQuestions();
    }
    private void ResetUnusedQuestions()
    {
        _unusedQuestions = new List<string>(_questions);
    }
    protected override void RunActivity()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        PauseWithSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            if (_unusedQuestions.Count == 0)
                ResetUnusedQuestions();

            int index = _random.Next(_unusedQuestions.Count);
            string question = _unusedQuestions[index];
            _unusedQuestions.RemoveAt(index);

            Console.Write($"\n{question} ");
            PauseWithSpinner(8); 
        }
    }
}