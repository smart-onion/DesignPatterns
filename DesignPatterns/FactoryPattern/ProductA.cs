namespace DesignPatterns.FactoryPattern;

public class ProductA : Product
{
    public void Prepare()
    {
        Console.WriteLine("Prepearing product A");
    }
}