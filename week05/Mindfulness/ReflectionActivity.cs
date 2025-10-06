using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What made this time different from others?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you apply this lesson in the future?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity",
               "This activity will help you reflect on times when you have shown strength and resilience.")
    {
    }

    public override void Run()
    {
        StartActivity();
        Random random = new Random();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions:");
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.Write($"> {question} ");
            PauseWithSpinner(4);
            Console.WriteLine();
        }

        EndActivity();
    }
}
