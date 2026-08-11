using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected int GetMinutes()
    {
        return _minutes;
    }

    protected string GetDate()
    {
        return _date;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min)- " +
            $"Distance {GetDistance():F1} miles, " +
            $"Speed {GetSpeed():F1} mph, " +
            $"Pace: {GetPace():F1} min per mile";
    }
}