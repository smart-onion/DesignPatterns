using DesignPatterns.FactoryPattern;
using DesignPatterns.AbstractFactoryPattern;
namespace DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        // Factory pattern
        var creator = new ProductACreator();
        var productA = creator.Make();
        
        // Abstract factory pattern
        Company apple = new AppleCompany();
        ICpu m4 = apple.CreateCpu();
        Company intel = new IntelCompany();
        IRam ram = intel.CreateRam();
        
        AssemblePc(m4, ram);
        
    }

    static void AssemblePc(ICpu cpu, IRam ram) // helper function for abstract factory pattern
    {
        cpu.Run();
        ram.GetRam();
    }
}