using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DesignPatterns.FactoryPattern;
using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.PrototypePattern;

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
        
        // Builder pattern
        var compBuilder = new ComputerBuilder<Macbook>();
        ComputerDirector.AssembleMacbookM4(compBuilder);
        Macbook mac = compBuilder.Assemble();
        mac.TurnOn();
        mac.GetInfo();
        
        //Prototype pattern
        ProductProto productProto = new ProductProto(1, "product");
        ProductProto productClone = (ProductProto) productProto.Clone();
    }

    static void AssemblePc(ICpu cpu, IRam ram) // helper function for abstract factory pattern
    {
        cpu.Run();
        ram.GetRam();
    }
}