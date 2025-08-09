class SimpleGoal : Goal
{
    private bool isDone;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        isDone = false;
    }

    public override int RecordEvent()
    {
        isDone = true;
        return points;
    }

    public override bool IsComplete()
    {
        return isDone;
    }

    public override string SaveString()
    {
        return $"Simple|{name}|{description}|{points}|{isDone}";
    }
}
