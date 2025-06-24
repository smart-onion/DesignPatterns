namespace DesignPatterns.ChainOfResponsibilityPattern;

public class PageNotFoundRoute:HttpHandler
{
    public override HttpRequest Handle(HttpRequest request)
    {
        request.StatusCode = 404;
        request.Success = false;
        request.Response = "404 PageNotFound";
        return request;
    }
}