using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private static readonly string[] prompts = {
        "--- Think of a time when you stood up for someone else. ---",
        "--- Think of a time when you did something really difficult. ---",
        "--- Think of a time when you helped someone in need. ---",
        "--- Think of a time when you did something truly selfless. ---"
    };

    private static readonly string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    protected override string GetDescription()
    {
        return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

protected override void Execute()
    {
        int duration = GetDuration();
        Random rand = new Random();

        // Mostrar el prompt inicial
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Length)]);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        AnimationHelper.Countdown(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.WriteLine("\n" + question);

            DateTime nextQuestionTime = DateTime.Now.AddSeconds(10);
            while (DateTime.Now < nextQuestionTime && DateTime.Now < endTime)
            {
                AnimationHelper.ShowSpinner(3);
            }
        }
    }
}
