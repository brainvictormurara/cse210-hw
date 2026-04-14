public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // This is for loading from a file
    public void SetComplete(bool status) => _isComplete = status;

    public override void RecordEvent() => _isComplete = true;

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation() => $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
}