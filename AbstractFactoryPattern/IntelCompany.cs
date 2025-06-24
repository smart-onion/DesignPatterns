namespace DesignPatterns.AbstractFactoryPattern;

public class IntelCompany: Company
{
    public override ICpu CreateCpu()
    {
        return new IntelI7();
    }

    public override IRam CreateRam()
    {
        return new IntelRam();
    }
}