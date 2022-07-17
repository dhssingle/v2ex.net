namespace V2ex;

public interface IV2exClient
{
    Task<TResponse?> SendAsync<TResponse>(HttpRequestMessage requestMessage);
}

