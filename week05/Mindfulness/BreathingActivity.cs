using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity",
               "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        bool inhale = true;

        while (DateTime.Now < endTime)
        {
            if (inhale)
            {
                Console.Write("\nBreathe in... ");
                Countdown(4);
            }
            else
            {
                Console.Write("\nBreathe out... ");
                Countdown(6);
            }
            inhale = !inhale;
        }

        EndActivity();
    }
}
