namespace V2ex.Tokens;

public class TokenService : ITokenService
{
    protected IV2exClient V2exClient { get; }

    public TokenService(IV2exClient v2exClient)
    {
        V2exClient = v2exClient;
    }

    public async Task<CreateTokenResponse?> CreateAsync()
    {
        var path = "v2/tokens";

        var request = new HttpRequestMessage(HttpMethod.Post, path);

        return await V2exClient.SendAsync<CreateTokenResponse>(request);
    }

    public async Task<GetTokenResponse?> GetAsync()
    {
        var path = "v2/token";

        var request = new HttpRequestMessage(HttpMethod.Get, path);

        return await V2exClient.SendAsync<GetTokenResponse>(request);
    }
}

