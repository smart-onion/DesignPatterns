namespace DesignPatterns.AbstractFactoryPattern;

public class IntelRam: IRam
{
    public void GetRam()
    {
        Console.WriteLine("running intel Ram");
    }
}