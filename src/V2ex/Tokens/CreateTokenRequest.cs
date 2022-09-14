namespace V2ex.Tokens;

public class CreateTokenRequest
{
    public string Scope { get; set; } = default!;

    public int Expiration { get; set; }
}

