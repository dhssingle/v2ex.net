namespace V2ex.Topics;

public interface ITopicService
{
    Task<NodeTopicsResponse?> GetNodeTopicsAsync(string nodeName,int p);

    Task<TopicDetailResponse?> GetAsync(int id);
}