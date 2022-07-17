namespace V2ex;

public interface IAuthTokenStore
{
    Task<TokenCacheItem?> GetTokenAsync();
}

