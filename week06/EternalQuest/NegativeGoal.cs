public class NegativeGoal : Goal
{
    private bool _isComplete;
    public NegativeGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }
    public NegativeGoal(string name, string description, int points, bool isComplete) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        return -Math.Abs(_points); // Soustrait des points
    }
    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}