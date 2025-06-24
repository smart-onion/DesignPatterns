using DesignPatterns.AbstractFactoryPattern;

namespace DesignPatterns.BuilderPattern;

public class Macbook : Computer
{
    public override void TurnOn()
    {
        Console.WriteLine("Macbook Turned On");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Macbook Turned Off");
    }

    public override void GetInfo()
    {
        Console.WriteLine($"Model: {Model}\n" +
                          $"Company: {Company}\n" +
                          $"CPU: {Cpu.ToString()}\n" +
                          $"RAM: {Ram.ToString()}");
    }
}