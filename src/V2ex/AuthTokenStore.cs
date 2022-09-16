using Microsoft.Extensions.Caching.Distributed;
using V2ex.Tokens;

namespace V2ex;

public class AuthTokenStore : IAuthTokenStore
{
    private const string key = "V2ex:PersonalAccessToken";
    private readonly IDistributedCache _distributedCache;
    private readonly ITokenService _tokenService;

    public AuthTokenStore(IDistributedCache distributedCache, ITokenService tokenService)
    {
        _distributedCache = distributedCache;
        _tokenService = tokenService;
    }

    public async Task<string> GetTokenAsync()
    {
        var cacheToken = await _distributedCache.GetStringAsync(key);

        if (cacheToken is null)
        {
            throw new NullReferenceException("token 无效");
        }

        return cacheToken;
    }

    public async Task SetTokenAsync(string token)
    {
        await SetCacheAsync(token, DateTimeOffset.Now.ToUnixTimeMilliseconds() + 5);

        await ValidateTokenAsync();
    }


    private async Task ValidateTokenAsync()
    {
        var response = await _tokenService.GetAsync();

        if (!response!.Success)
        {
            throw new HttpRequestException(response.Message);
        }

        await SetCacheAsync(response.GetToken(), response.GetAbsoluteExpiration());
    }

    private async Task SetCacheAsync(string token, long expiration)
    {
        await _distributedCache.RemoveAsync(key);

        await _distributedCache.SetStringAsync(key, token, new DistributedCacheEntryOptions
        {
            AbsoluteExpiration = DateTimeOffset.FromUnixTimeSeconds(expiration)
        });
    }
}

