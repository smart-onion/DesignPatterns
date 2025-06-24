namespace DesignPatterns.CommandPattern;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"console: {message}");
    }
}