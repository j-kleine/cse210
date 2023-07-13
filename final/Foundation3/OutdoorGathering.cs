using System;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather: {_weather}";
    }
}
