using System;
using System.Collections.Generic;

// ===============================
// Base Class: Activity
// ===============================
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    // Abstract methods (must be implemented by derived classes)
    public abstract double GetDistance();  // km
    public abstract double GetSpeed();     // kph
    public abstract double GetPace();      // min/km

    // Shared summary output
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min): " +
               $"Distance {GetDistance():F2} km, " +
               $"Speed {GetSpeed():F2} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }
}

// ===============================
// Derived Class: Running
// ===============================
public class Running : Activity
{
    private double _distance; // in km

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed()
    {
        // Speed = (distance / minutes) * 60
        return (_distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        // Pace = minutes / distance
        return Minutes / _distance;
    }
}

// ===============================
// Derived Class: Cycling
// ===============================
public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Distance = (speed * minutes) / 60
        return (_speed * Minutes) / 60;
    }

    public override double GetSpeed() => _speed;

    public override double GetPace()
    {
        // Pace = 60 / speed
        return 60 / _speed;
    }
}

// ===============================
// Derived Class: Swimming
// ===============================
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance in km = laps * 50 / 1000
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        // Speed = (distance / minutes) * 60
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        // Pace = minutes / distance
        return Minutes / GetDistance();
    }
}

// ===============================
// Program Execution
// ===============================
public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 3), 40, 15.0),
            new Swimming(new DateTime(2022, 11, 3), 25, 20)
        };

        Console.WriteLine("=== Exercise Summary ===\n");
        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
