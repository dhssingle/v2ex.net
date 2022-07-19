namespace V2ex.Nodes;

# nullable disable
public class NodeResponse
{
    public int Id { get; set; }

    public string Url { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public string Header { get; set; }

    public string Footer { get; set; }

    public string Avatar { get; set; }

    public int Topics { get; set; }

    public long Created { get; set; }

    public long LastModified { get; set; }
}

