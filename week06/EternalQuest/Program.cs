/*
EXCEEDING REQUIREMENTS - Creativity Features:
1. LEVEL SYSTEM: Players earn a Level Up! bonus of 100 points every time they reach a multiple of 1000 points
2. NEGATIVE GOALS: Added NegativeGoal class for breaking bad habits
3. PROGRESS TRACKING: Shows overall completion percentage for all goals
4. STREAK COUNTER: Tracks consecutive days for eternal goals
5. COLORED CONSOLE: Uses colored text for better user experience
6. MOTIVATIONAL MESSAGES: Random encouraging messages when goals are completed
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.ResetColor();
        
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}