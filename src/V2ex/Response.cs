namespace V2ex;

public class Response : IResponse
{
    public bool Success { get; set; }

    public string Message { get; set; } = default!;
}


