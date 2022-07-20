using System.Text.Json.Serialization;

namespace V2ex.Topics;

# nullable disable
public class TopicsResponse : Response
{
    public IReadOnlyList<Topic> Result { get; set; }
}

public class Topic
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    [JsonPropertyName("content_rendered")]
    public string ContentRendered { get; set; }

    public int Syntax { get; set; }

    public string Url { get; set; }

    public int Replies { get; set; }

    [JsonPropertyName("last_reply_by")]
    public string LastReplyBy { get; set; }

    public long Created { get; set; }

    [JsonPropertyName("last_modified")]
    public long LastModified { get; set; }

    [JsonPropertyName("last_touched")]
    public long LastTouched { get; set; }
}

