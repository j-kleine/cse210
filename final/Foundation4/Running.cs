public class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / base.GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return base.GetDuration() / _distance;
    }
}
