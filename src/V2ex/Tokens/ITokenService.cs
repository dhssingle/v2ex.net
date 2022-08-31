namespace V2ex.Tokens;

public interface ITokenService
{
    Task<GetTokenResponse?> GetAsync();

    Task<CreateTokenResponse?> CreateAsync();
}

