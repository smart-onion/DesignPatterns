using System.Diagnostics.Tracing;

namespace DesignPatterns.FactoryPattern;

public abstract class Creator<T>
{
    public T Make()
    {
        return Create();
    }
    protected abstract T Create();
}