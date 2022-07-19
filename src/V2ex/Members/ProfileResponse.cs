using System.Text.Json.Serialization;

namespace V2ex.Members;

# nullable disable
public class ProfileResponse
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Url { get; set; }

    public string Website { get; set; }

    public string Twitter { get; set; }

    public string Github { get; set; }

    public string Btc { get; set; }

    public string Location { get; set; }

    public string Tagline { get; set; }

    public string Bio { get; set; }

    [JsonPropertyName("avatar_mini")]
    public string AvatarMini { get; set; }

    [JsonPropertyName("avatar_normal")]
    public string AvatarNormal { get; set; }

    [JsonPropertyName("avatar_large")]
    public string AvatarLarge { get; set; }

    public long Created { get; set; }

    [JsonPropertyName("last_modified")]
    public long LastModified { get; set; }
}

