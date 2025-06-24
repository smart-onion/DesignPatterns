namespace DesignPatterns.ChainOfResponsibilityPattern;

public class HttpRequest
{
    public string Path { get; set; }
    public string Method { get; set; }
    public string Data { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; }
    public int StatusCode { get; set; }
    public string Response { get; set; }
}