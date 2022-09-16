using System.Net.Http.Headers;

namespace V2ex;

public class AuthenticatedHttpClientHandler : DelegatingHandler
{
    private readonly IAuthTokenStore _authTokenStore;

    public AuthenticatedHttpClientHandler(IAuthTokenStore authTokenStore)
    {
        _authTokenStore = authTokenStore;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = await _authTokenStore.GetTokenAsync();

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

        return await base.SendAsync(request, cancellationToken);
    }
}

