using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted < _target)
        {
            Console.WriteLine($"Progress: {_amountCompleted}/{_target}");
            Console.WriteLine($"You earned {GetPoints()} points!");
        }
        else if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You completed the checklist goal and earned a bonus of {_bonus}!");
        }
        else
        {
            Console.WriteLine("Goal already completed.");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted}";
    }
}