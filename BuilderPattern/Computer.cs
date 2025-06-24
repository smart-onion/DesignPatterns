using DesignPatterns.AbstractFactoryPattern;

namespace DesignPatterns.BuilderPattern;

public abstract class Computer
{   
    public string Company { get; set; }
    public string Model { get; set; }
    public IRam Ram { get; set; }
    public ICpu Cpu { get; set; }

    public abstract void TurnOn();
    public abstract void TurnOff();

    public abstract void GetInfo();
}