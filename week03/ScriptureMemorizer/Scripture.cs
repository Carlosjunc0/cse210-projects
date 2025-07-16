using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference reference;
        private List<Word> words;
        private Random rand = new Random();

        public Scripture(Reference reference, string text)
        {
            this.reference = reference;
            this.words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

        public void HideRandomWords(int count)
        {
            var visibleWords = words.Where(w => !w.IsHidden()).ToList();
            if (visibleWords.Count == 0) return;

            for (int i = 0; i < count && visibleWords.Count > 0; i++)
            {
                int index = rand.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }

        public bool AllWordsHidden()
        {
            return words.All(w => w.IsHidden());
        }

        public string GetDisplayText()
        {
            string verseText = string.Join(" ", words.Select(w => w.GetDisplayText()));
            return $"{reference.GetDisplayText()}\n{verseText}";
        }
    }
}
