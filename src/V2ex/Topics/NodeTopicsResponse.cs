namespace V2ex.Topics;

public class NodeTopicsResponse : Response
{
    public IReadOnlyList<NodeTopic> Result { get; set; } = default!;
}

