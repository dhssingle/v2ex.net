using System.Net.Http.Headers;

namespace V2ex;

public class AuthHeaderHandler : DelegatingHandler
{
    private readonly IAuthTokenStore _authTokenStore;

    public AuthHeaderHandler(IAuthTokenStore authTokenStore)
    {
        _authTokenStore = authTokenStore;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var cacheItem = await _authTokenStore.GetTokenAsync();

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", cacheItem?.Token);

        return await base.SendAsync(request, cancellationToken);
    }
}

