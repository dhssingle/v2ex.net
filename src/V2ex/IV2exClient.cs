namespace V2ex;

public interface IV2exClient
{
    Task<IResponse?> SendAsync<IResponse>(HttpRequestMessage requestMessage);
}

