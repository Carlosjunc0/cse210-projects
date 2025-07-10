using System;
using System.Collections.Generic;
namespace JournalApp
{
    public class PromptGenerator
    {
        private List<string> _prompts;
        private Random _random;

        public PromptGenerator()
        {
            _prompts = new List<string>
            {
                "What was the best thing about your day?",
                "What did you learn today?",
                "What could you have done better?",
                "What did you do well today?",
                "What made you smile today?"
            };
            _random = new Random();
        }

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}