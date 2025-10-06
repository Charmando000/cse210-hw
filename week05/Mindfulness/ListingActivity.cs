using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "What are things that make you happy?",
        "Who are your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many as you can.")
    {
    }

    public override void Run()
    {
        StartActivity();
        Random random = new Random();

        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");
        Console.WriteLine("\nYou may begin in: ");
        Countdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndActivity();
    }
}
