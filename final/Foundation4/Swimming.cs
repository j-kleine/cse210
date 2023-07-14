public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / base.GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return base.GetDuration() / GetDistance();
    }
}
