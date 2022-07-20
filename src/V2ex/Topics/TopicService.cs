namespace V2ex.Topics;

public class TopicService : ITopicService
{
    protected IV2exClient V2exClient { get; }

    public TopicService(IV2exClient v2exClient)
    {
        V2exClient = v2exClient;
    }

    public async Task<TopicsResponse?> GetListAsync(string nodeName, int p)
    {
        var path = $"api/v2/nodes/{nodeName}}/topics?p={p}";

        var request = new HttpRequestMessage(HttpMethod.Get, path);

        return await V2exClient.SendAsync<TopicsResponse>(request);
    }
}