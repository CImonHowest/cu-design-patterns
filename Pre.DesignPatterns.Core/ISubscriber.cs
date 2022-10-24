namespace Pre.DesignPatterns.Core;

public interface ISubscriber
{
    void Update(ISubject sender, Episode episdoe);
}