using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    public class Journal
    {
        private List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }
        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }
        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries yet.\n");
                return;
            }
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.ToCsvLine());
                }
            }
            Console.WriteLine($"Journal saved to {filename}\n");
        }
        public void LoadFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File {filename} not found.\n");
                return;
            }
            List<Entry> newEntries = new List<Entry>();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    Entry entry = Entry.FromCsvLine(line);
                    if (entry != null)
                       newEntries.Add(entry);
                }
            } 
            _entries = newEntries;
            Console.WriteLine($"Journal loaded from {filename} ({_entries.Count} entries)\n");
        }
    }
}