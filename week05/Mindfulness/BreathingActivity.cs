using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    protected override void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            PauseWithCountdown(4);
            Console.Write("\nBreathe out... ");
            PauseWithCountdown(4);
        }
    }
}