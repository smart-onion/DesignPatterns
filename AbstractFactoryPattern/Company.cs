namespace DesignPatterns.AbstractFactoryPattern;

public abstract class Company // abstract factory
{
    public abstract ICpu CreateCpu();
    public abstract IRam CreateRam();
}