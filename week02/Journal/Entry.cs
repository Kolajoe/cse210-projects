using System;
using System.Security.Cryptography;

namespace JournalProgram
{
    public class Entry
    {
        public string _date;
        public string _prompt;
        public string _response;
        public string _mood;

        public Entry(string date, string prompt, string response, string mood ="")
        {
            _date = date;
            _prompt = prompt;
            _response = response;
            _mood = mood;
        }
        public void Display()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_prompt}");
            if (!string.IsNullOrEmpty(_mood))
                Console.WriteLine($"Mood: {_mood}");
            Console.WriteLine($"Response: {_response}");
            Console.WriteLine("...............");
        }
        public string ToCsvLine()
        {
            string Escape(string s)
            {
                if (s.Contains(",") || s.Contains("\"") || s.Contains("\n"))
                   return "\"" + s.Replace("\"", "\"\"") + "\"";
                return s;
            }
            return $"{Escape(_date)}|{Escape(_prompt)}|{Escape(_response)}|{Escape(_mood)}";
        }
        public static Entry FromCsvLine(string line)
        {
            string[] parts = line.Split('|');
            if (parts.Length >=3)
            {
                string date = parts[0].Trim('"');
                string prompt = parts[1].Trim('"');
                string response = parts[2].Trim('"');
                string mood = parts.Length >= 4? parts[3].Trim('"') : "";
                return new Entry(date, prompt, response, mood);
            }
            return null;
        }
    }
}