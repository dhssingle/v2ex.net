namespace V2ex;

public interface IV2exClient
{
    Task<Response<T>?> SendAsync<T>(HttpRequestMessage requestMessage);
}

