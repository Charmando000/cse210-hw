using System;
using System.IO;
using System.Threading;

abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("\nEnter the duration of this activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready...");
        PauseWithSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Well done! you have completed the {_name} for {_duration} seconds.");
        PauseWithSpinner(3);
        LogActivity();
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            index = (index + 1) % spinner.Length;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    private void LogActivity()
    {
        string logEntry = $"{DateTime.Now}: {_name} for {_duration} seconds";
        File.AppendAllText("activity_log.txt", logEntry + Environment.NewLine);
    }
    
     public abstract void Run();
}