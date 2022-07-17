using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System.Net.Http.Headers;

namespace V2ex;

public class AuthTokenStore : IAuthTokenStore
{
    private const string key = "V2ex:PersonalAccessToken";
    private readonly IDistributedCache _distributedCache;
    private readonly IHttpClientFactory _httpClientFactory;

    public AuthTokenStore(IDistributedCache distributedCache, IHttpClientFactory httpClientFactory)
    {
        _distributedCache = distributedCache;
        _httpClientFactory = httpClientFactory;
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

    public async Task SetTokenAsync(string token)
    {
        var tokenCacheItem = await GetTokenAsync(token);

        if (tokenCacheItem is null)
        {
            throw new NullReferenceException("无法获取到 Token");
        }

        await _distributedCache.SetStringAsync(key, tokenCacheItem.Token, new DistributedCacheEntryOptions
        {
            AbsoluteExpiration = DateTimeOffset.FromUnixTimeSeconds(tokenCacheItem.Created + tokenCacheItem.Expiration)
        });
    }

    private async Task<TokenCacheItem?> GetTokenAsync(string token)
    {
        var client = _httpClientFactory.CreateClient();

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var resultStream = await client.GetStreamAsync("api/v2/token");

        var document = await JsonDocument.ParseAsync(resultStream);

        return document.RootElement.GetProperty("result").Deserialize<TokenCacheItem>();
    }
}

