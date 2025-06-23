namespace DesignPatterns.AbstractFactoryPattern;

public class AppleRam: IRam
{
    public void GetRam()
    {
        Console.WriteLine("running apple Ram");
    }
}