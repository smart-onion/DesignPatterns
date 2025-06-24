using DesignPatterns.AbstractFactoryPattern;

namespace DesignPatterns.BuilderPattern;

public class ComputerBuilder<T> : IComputerBuilder where T : Computer, new()
{
    private T _computer = new T();
    
    public void Reset()
    {
        _computer = new T();
    }

    public IComputerBuilder Company(string company)
    {
        _computer.Company = company;
        return this;
    }

    public IComputerBuilder Model(string model)
    {
        _computer.Model = model;
        return this;
    }

    public IComputerBuilder Cpu(ICpu cpu)
    {
        _computer.Cpu = cpu;
        return this;
    }

    public IComputerBuilder Ram(IRam ram)
    {
        _computer.Ram = ram;
        return this;
    }

    public T Assemble() 
    {
        var comp = _computer;
        this.Reset();
        return comp;
    }
}