using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; 

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        ShowStartingMessage();
        SetDuration();
        ShowPrepareMessage();
        PauseWithSpinner(3); 
        RunActivity();
        ShowEndingMessage();
    }

    private void ShowStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine(_description);
    }

    private void SetDuration()
    {
        Console.Write("How many seconds would you like this activity to last? ");
        _duration = int.Parse(Console.ReadLine());
    }

    private void ShowPrepareMessage()
    {
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3);
    }

    private void ShowEndingMessage()
    {
        Console.WriteLine("\nGood job!");
        PauseWithSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\b \b{spinner[i % 4]}");
            Thread.Sleep(250);
        }
        Console.Write("\b \b");
    }

    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\b \b{i}");
            Thread.Sleep(1000);
        }
        Console.Write("\b \b");
    }

    protected abstract void RunActivity();
}