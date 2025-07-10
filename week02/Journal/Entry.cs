using System;

namespace JournalApp
{
    public class Entry
    {
        public string Date { get; private set; }
        public string Prompt { get; private set; }
        public string Response { get; private set; }

        public Entry(string prompt, string response)
        {
            Date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            Prompt = prompt;
            Response = response;
        }

        public void Display()
        {
            Console.WriteLine($"[{Date}] {Prompt}");
            Console.WriteLine($"Response: {Response}\n");
        }

        public string ToFileString()
        {
            return $"{Date}|{Prompt}|{Response}";
        }

        public static Entry FromFileString(string line)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1], parts[2]);
                entry.Date = parts[0];
                return entry;
            }
            return null;
        }
    }
}
