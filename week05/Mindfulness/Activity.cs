using System;

public abstract class Activity
{
    private int duration;

    public void Start()
    {
        ShowStartMessage();
        AnimationHelper.ShowSpinner(3);
        Execute();
        ShowEndMessage();
    }

    protected virtual void ShowStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetType().Name.Replace("Activity", "")} Activity");
        Console.WriteLine($"\n"+GetDescription());
        Console.Write("\nHow long, in seconds, would you like for your season? ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready...");
        Console.Clear();
    }

    protected virtual void ShowEndMessage()
    {
        Console.WriteLine("\nWell done!!");
        AnimationHelper.ShowSpinner(2);
        Console.WriteLine($"You have completed another {duration} seconds of the {GetType().Name.Replace("Activity", "")} Activity");
        AnimationHelper.ShowSpinner(3);
    }

    protected int GetDuration() => duration;

    protected abstract void Execute();
    protected abstract string GetDescription();
}
