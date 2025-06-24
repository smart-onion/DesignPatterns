namespace DesignPatterns.CommandPattern;

public class Application
{
    ILogger logger;
    
    public Application(ILogger logger) => this.logger = logger;

    public void Log(string message)
    {
        logger.Log(message);
    }
}