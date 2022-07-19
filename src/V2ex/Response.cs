namespace V2ex;
public class Response
{
    public bool Success { get; set; }
    
    public string Message { get; set; } = default!;
}

public class Response<T> : Response
{
    public T Result { get; set; } = default!;
}

