class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        return points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveString()
    {
        return $"Eternal|{name}|{description}|{points}";
    }
}
