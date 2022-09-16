using System.Text.Json.Serialization;

namespace V2ex.Tokens;

public class GetTokenResponse : Response
{
    public TokenInfo? Result { get; set; }

    public long GetAbsoluteExpiration()
    {
        return Result!.Created + Result!.Expiration;
    }

    public string GetToken()
    {
        return Result!.Token;
    }
}

public class TokenInfo
{
    public string Token { get; set; } = default!;

    public string Scope { get; set; } = default!;

    public int Expiration { get; set; }

    [JsonPropertyName("good_for_days")]
    public int GoodForDays { get; set; }

    [JsonPropertyName("total_used")]
    public int TotalUsed { get; set; }

    [JsonPropertyName("last_used")]
    public long LastUsed { get; set; }

    public long Created { get; set; }
}

