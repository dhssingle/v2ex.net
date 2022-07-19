using System.Text.Json.Serialization;

namespace V2ex.Notifications;

public class NotificationResponse
{
    public int Id { get; set; }

    [JsonPropertyName("member_id")]
    public int MemberId { get; set; }

    [JsonPropertyName("for_member_id")]
    public int ForMemberId { get; set; }

    public string Text { get; set; } = default!;

    public string Payload { get; set; } = default!;

    [JsonPropertyName("payload_rendered")]
    public string PayloadRendered { get; set; } = default!;

    public long Created { get; set; }

    public Member Member { get; set; } = default!;
}

public class Member
{
    public string Username { get; set; } = default!;
}



