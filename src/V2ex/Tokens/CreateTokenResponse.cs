namespace V2ex.Tokens;

public class CreateTokenResponse : Response
{
    public Result? Result { get; set; }
}

public class Result
{
    public string? Token { get; set; }
}

