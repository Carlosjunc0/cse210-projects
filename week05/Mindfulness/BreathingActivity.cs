using System;

public class BreathingActivity : Activity
{
    protected override string GetDescription()
    {
        return "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void Execute()
    {
        int duration = GetDuration();
        int cycleTime = 6;
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            AnimationHelper.Countdown(3);
            Console.WriteLine("Now breathe out...");
            AnimationHelper.Countdown(3);
            elapsed += cycleTime;
        }
    }
}
