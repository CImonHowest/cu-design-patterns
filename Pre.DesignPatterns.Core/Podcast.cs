using System.Collections.Immutable;

namespace Pre.DesignPatterns.Core;

public class Podcast : ISubject
{
    public string Title { get; }
    private ICollection<Episode> _episodes;
    private ICollection<ISubscriber> _subscribers;

    public ICollection<Episode> Episodes => _episodes.ToImmutableList();

    public Podcast(string title, ICollection<Person> subscribers)
    {
        Title = title;
        _subscribers = new List<ISubscriber>(subscribers);
    }

    public void AddSubscriber(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Notify()
    {
        Notify(null);
    }

    public void Notify(Episode episode)
    {
        _subscribers.ToList().ForEach(s => s.Update(this, episode));
    }

    public void AddEpisode(Episode episode)
    {
        _episodes.Add(episode);
        Notify(episode);
    }
}