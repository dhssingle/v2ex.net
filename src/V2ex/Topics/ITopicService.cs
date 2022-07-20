namespace V2ex.Topics;

public interface ITopicService
{
    Task<TopicsResponse?> GetListAsync(string nodeName,int p);
}