public abstract class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{GetDate()} {GetType().Name} ({GetDuration()} min): Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }
}
