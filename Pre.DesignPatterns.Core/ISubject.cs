namespace Pre.DesignPatterns.Core;

public interface ISubject
{
    void AddSubscriber(ISubscriber subscriber);
    void RemoveSubscriber(ISubscriber subscriber);
    void Notify();
    void Notify(Episode episode);
}