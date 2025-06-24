using DesignPatterns.AbstractFactoryPattern;

namespace DesignPatterns.BuilderPattern;

public interface IComputerBuilder
{
    public void Reset();
    public IComputerBuilder Company(string name);

    public IComputerBuilder Model(string model);

    public IComputerBuilder Cpu(ICpu cpu);

    public IComputerBuilder Ram(IRam ram);

}