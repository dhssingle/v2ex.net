namespace V2ex;

public class TokenCacheItem
{
    public string Token { get; set; } = default!;

    public string Scope { get; set; } = default!;

    public int Expiration { get; set; }

    public long Created { get; set; }

}

