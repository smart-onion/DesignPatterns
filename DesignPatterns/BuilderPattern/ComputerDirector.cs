using DesignPatterns.AbstractFactoryPattern;

namespace DesignPatterns.BuilderPattern;

public static class ComputerDirector
{
    public static void AssembleMacbookM4(IComputerBuilder builder)
    {
        builder.Company("Apple")
            .Model("M4")
            .Cpu(new M4())
            .Ram(new AppleRam());
    }

    public static void AssembleLenovoLegion(IComputerBuilder builder)
    {
        builder.Company("Lenovo")
            .Model("Legion Pro")
            .Cpu(new IntelI7())
            .Ram(new IntelRam());
    }
}