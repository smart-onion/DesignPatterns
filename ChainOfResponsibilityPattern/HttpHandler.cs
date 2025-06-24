using DesignPatterns.AbstractFactoryPattern;

namespace DesignPatterns.ChainOfResponsibilityPattern;

public abstract class HttpHandler
{
    private HttpHandler _next;

    public HttpHandler SetNext(HttpHandler next)
    {
        _next = next;
        return next;
    }

    protected HttpRequest NextHandler(HttpRequest request)
    {
        if (_next == null)
        {
            request.Success = true;
            return request;
        }
        return _next.Handle(request);
    }
    public abstract HttpRequest Handle(HttpRequest request);
}