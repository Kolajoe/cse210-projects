using System;
using System.Collections.Generic;
public static class ActivityLogger
{
    private static Dictionary<string, int> _sessionCounts = new Dictionary<string, int>();
    public static void LogActivity(string activityName)
    {
        if (_sessionCounts.ContainsKey(activityName))
            _sessionCounts[activityName]++;
        else
            _sessionCounts[activityName] = 1;
    }
    public static void ShowSummary()
    {
        Console.WriteLine("\n--- Session Summary ---");
        foreach (var entry in _sessionCounts)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} time(s)");
        }
        Console.WriteLine("-----------------------\n");
    }
}