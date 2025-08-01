using System;

public static class AnimationHelpers
{
    public static void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(spinner[i++ % spinner.Length]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    //public static void Countdown1(int seconds)
    //{
    //    List<string> animationNumber = new List<string>();
    //    animationNumber.Add("5");
    //    animationNumber.Add("4");
    //    animationNumber.Add("3");
    //    animationNumber.Add("2");
    //    animationNumber.Add("1");
//
    //    DateTime startTime = DateTime.Now;
    //    DateTime endTime = startTime.AddSeconds(5);
//
    //    int i = 0;
//
    //    while (DateTime.Now < endTime)
    //    {
    //        string s = animationNumber[i];
    //        Console.Write(s);
    //        Thread.Sleep(1000);
    //        Console.Write("\b \b");
//
    //        i++;
//
    //        if (i >= animationNumber.Count)
    //        {
    //            i = 0;
    //        }
    //    }
    //}
}
