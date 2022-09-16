namespace V2ex;

public interface IAuthTokenStore
{
    Task<string> GetTokenAsync();

    Task SetTokenAsync(string token);
}

