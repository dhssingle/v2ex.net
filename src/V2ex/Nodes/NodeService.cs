namespace V2ex.Nodes;

public class NodeService : INodeService
{
    protected V2exClient V2exClient { get; }

    public NodeService(V2exClient v2exClient)
    {
        V2exClient = v2exClient;
    }

    public async Task<Response<NodeResponse>?> GetAsync(string name)
    {
        var path = $"api/v2/nodes/{name}";

        return await V2exClient.SendAsync<NodeResponse>(new HttpRequestMessage(HttpMethod.Get, path));
    }
}

