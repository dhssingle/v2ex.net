using System;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Http;
using System.Text.Json;
using System.Text;

namespace V2ex;

public class AuthTokenStore : IAuthTokenStore
{
    private const string key = "V2ex:PersonalAccessToken";
    private readonly IDistributedCache _distributedCache;

    public AuthTokenStore(IDistributedCache distributedCache)
    {
        _distributedCache = distributedCache;
    }

    public async Task<TokenCacheItem?> GetTokenAsync()
    {
        var cache = await _distributedCache.GetStringAsync(key);

        if (cache is null)
        {
            throw new NullReferenceException("无法获取到 Token");
        }

        return JsonSerializer.Deserialize<TokenCacheItem>(cache);
    }
}

