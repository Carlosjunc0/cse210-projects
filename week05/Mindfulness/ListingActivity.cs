using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    protected override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many thing as you can in a certain area.";
    }

    protected override void Execute()
    {
        int duration = GetDuration();
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        AnimationHelper.Countdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
    }
}
