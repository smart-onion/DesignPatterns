using DesignPatterns.FactoryPattern;
using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.PrototypePattern;
using DesignPatterns.AdapterPattern;
using DesignPatterns.ChainOfResponsibilityPattern;

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
        
        // Adapter pattern
        IShape rectangle = new Rectangle(10, 20);
        ShapeAdapter shapeAdapter = new ShapeAdapter(rectangle);
        PaintShape(shapeAdapter);
        
        // Chain of Responsibility pattern
        var root = new HomeRoute();
        root.SetNext(new AboutRoute())
            .SetNext(new PageNotFoundRoute());
        HttpRequest request = new HttpRequest();
        request.Path = "/abouts";
        
        var response = root.Handle(request);
        Console.WriteLine(response.Response);
    }

    static void AssemblePc(ICpu cpu, IRam ram) // helper function for abstract factory pattern
    {
        cpu.Run();
        ram.GetRam();
    }

    
    
    static void PaintShape(IColor color) // helper function for adapter pattern
    {
        Console.WriteLine(color.GetColor());
    }
}