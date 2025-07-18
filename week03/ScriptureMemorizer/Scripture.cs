using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference reference;
        private List<Word> words;

        public Scripture(Reference reference, string text)
        {
            this.reference = reference;
            this.words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

        public void HideRandomWords(int count)
        {
            var visibleWords = words.Where(w => !w.IsHidden()).ToList();
            if (visibleWords.Count == 0) return;

            Random rand = new Random();
            int hidden = 0;

            while (hidden < count)
            {
                int index = rand.Next(words.Count);

                if (!words[index].IsHidden())
                {
                    words[index].Hide();
                    hidden++;
                }
            }
        }

        public string GetDisplayText()
        {
            string result = reference.GetDisplayText() + " - ";
            foreach (Word word in words)
            {
                result += word.GetDisplayText() + " ";
            }
            return result.Trim();
        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in words)
            {
                if (!word.IsHidden())
                    return false;
            }
            return true;
        }
        public bool AllWordsHidden()
        {
            foreach (Word word in words)
            {
                if (!word.IsHidden())
                    return false;
            }
            return true;
        }
    }
}