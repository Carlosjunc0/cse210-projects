class ChecklistGoal : Goal
{
    private int timesDone;
    private int timesNeeded;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int timesNeeded, int bonus)
        : base(name, description, points)
    {
        this.timesNeeded = timesNeeded;
        this.bonus = bonus;
        timesDone = 0;
    }

    public override int RecordEvent()
    {
        timesDone++;
        if (timesDone >= timesNeeded)
        {
            return points + bonus;
        }
        return points;
    }

    public override bool IsComplete()
    {
        return timesDone >= timesNeeded;
    }

    public override string GetDetails()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {name} ({description}) -- Currently completed: {timesDone}/{timesNeeded}";
    }

    public override string SaveString()
    {
        return $"Checklist|{name}|{description}|{points}|{timesNeeded}|{bonus}|{timesDone}";
    }
}
