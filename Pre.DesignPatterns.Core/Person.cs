namespace Pre.DesignPatterns.Core;

public class Person: ISubscriber
{
    public string Name { get; set; }

    private void SendMessage(Episode episode)
    {
        Console.WriteLine($"A new episode was added for {Name}: {episode.Name}");
    }

    public void Update(ISubject sender, Episode episdoe)
    {
        SendMessage(episdoe);
    }
}