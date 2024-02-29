using System;
using System.Collections.Generic;

// Subject interface
public interface ISubject
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

// Observer interface
public interface IObserver
{
    void Update(string message);
}

// Concrete Subject
public class NewsAgency : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private string _news;

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_news);
        }
    }

    public void SetNews(string news)
    {
        _news = news;
        NotifyObservers();
    }
}

// Concrete Observer
public class NewsChannel : IObserver
{
    private string _name;

    public NewsChannel(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} received news: {message}");
    }
}

class Program
{
    static void Main()
    {
        // Creating subjects and observers
        var newsAgency = new NewsAgency();
        var channel1 = new NewsChannel("Channel 1");
        var channel2 = new NewsChannel("Channel 2");

        // Registering observers to the subject
        newsAgency.AddObserver(channel1);
        newsAgency.AddObserver(channel2);

        // Updating the subject's state triggers notification to observers
        newsAgency.SetNews("Breaking News: Important event!");

        // Output:
        // Channel 1 received news: Breaking News: Important event!
        // Channel 2 received news: Breaking News: Important event!
    }
}
