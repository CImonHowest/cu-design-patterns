namespace Pre.DesignPatterns.Core;

public class SystemLogger
{
    private static SystemLogger _instance;

    private SystemLogger() { }

    public static SystemLogger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SystemLogger();
        }

        return _instance;
    }

    public void Log(string title, string message)
    {
        Console.WriteLine($"Write following to file: {title} {message}");
    }

}