using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(
            new DateTime(2022, 11, 3), 
            30, 
            3.0 
        );

        Cycling cycling = new Cycling(
            new DateTime(2022, 11, 4), 
            45, 
            12.0  
        );
        Swimming swimming = new Swimming(
            new DateTime(2022, 11, 5), 
            60, 
            30  
        );

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("Exercise Tracking Program\n");
        Console.WriteLine("Activities Summary:");
        Console.WriteLine("===================\n");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}