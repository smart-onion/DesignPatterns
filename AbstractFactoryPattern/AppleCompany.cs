namespace DesignPatterns.AbstractFactoryPattern;

public class AppleCompany: Company
{
    public override ICpu CreateCpu()
    {
        return new M4();
    }

    public override IRam CreateRam()
    {
        return new AppleRam();
    }
}