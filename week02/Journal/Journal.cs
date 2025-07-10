using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
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

        public void DisplayEntries()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries in Journal.");
            }
            else
            {
                foreach (Entry entry in _entries)
                {
                    entry.Display();
                }
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter($"{filename}.txt"))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.ToFileString());
                }
            }
            Console.WriteLine("Journal saved!");
        }

        public void LoadFromFile(string filename)
        {
            try
            {
                _entries.Clear();
                string[] lines = File.ReadAllLines($"{filename}.txt");
                foreach (string line in lines)
                {
                    Entry entry = Entry.FromFileString(line);
                    if (entry != null)
                    {
                        _entries.Add(entry);
                    }
                }
                Console.WriteLine("File loaded");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
    }
}
