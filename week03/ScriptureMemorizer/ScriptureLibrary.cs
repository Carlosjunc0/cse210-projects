using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class ScriptureLibrary
    {
        private List<Scripture> scriptures;
        private Random rand = new Random();

        public ScriptureLibrary()
        {
            scriptures = new List<Scripture>();
            LoadScriptures();
        }

        private void LoadScriptures()
        {
            scriptures.Add(new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));

            scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart, and lean not on your own understanding; in all your ways acknowledge Him, and He shall direct your paths."));
        }

        public Scripture GetRandomScripture()
        {
            int index = rand.Next(scriptures.Count);
            return scriptures[index];
        }
    }
}