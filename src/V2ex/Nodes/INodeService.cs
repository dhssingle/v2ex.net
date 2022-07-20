namespace V2ex.Nodes;

public interface INodeService
{
    Task<NodeResponse?> GetAsync(string name);
}
