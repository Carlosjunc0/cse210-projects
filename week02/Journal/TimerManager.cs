using System;

namespace JournalApp
{
    public class TimerManager
    {
        private DateTime _startTime;

        public TimerManager()
        {
            _startTime = DateTime.Now;
        }

        public TimeSpan GetElapsedTime()
        {
            return DateTime.Now - _startTime;
        }

        public void DisplayElapsedTime()
        {
            TimeSpan elapsed = GetElapsedTime();
            Console.WriteLine($"\nTime elapsed since you opened the journal: {elapsed.Hours}h {elapsed.Minutes}m {elapsed.Seconds}s");
        }
    }
}
