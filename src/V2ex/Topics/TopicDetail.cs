using V2ex.Nodes;

namespace V2ex.Topics;

#nullable disable
public class TopicDetail : NodeTopic
{
    public Member Member { get; set; }

    public Node Node { get; set; }
}

public class Member
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Website { get; set; }

    public string Bio { get; set; }

    public string Github { get; set; }

    public string Url { get; set; }

    public string Avatar { get; set; }

    public long Created { get; set; }
}


