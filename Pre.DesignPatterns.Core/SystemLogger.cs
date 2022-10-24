namespace Pre.DesignPatterns.Core;

public class SystemLogger
{
    private SystemLogger()
    {
        
    }

    public SystemLogger GetInstance()
    {
        return new SystemLogger();
    }

    public void Log(string title, string message)
    {
        Console.WriteLine($"Write following to file: {title} {message}");
    }
}