namespace DesignPatterns.CommandPattern;

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"file: {message}");
    }
}