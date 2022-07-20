namespace V2ex.Notifications;

public class NotificationService : INotificationService
{
    protected IV2exClient V2exClient { get; }

    public NotificationService(IV2exClient v2exClient)
    {
        V2exClient = v2exClient;
    }

    public async Task<NotificationsResponse?> GetListAsync(int p)
    {
        var path = $"api/v2/notifications?p={p}";

        return await V2exClient.SendAsync<NotificationsResponse>(new HttpRequestMessage(HttpMethod.Get, path));
    }

    public async Task DeleteAsync(int id)
    {
        var path = $"api/v2/notifications/{id}";

        await V2exClient.SendAsync<Response>(new HttpRequestMessage(HttpMethod.Delete, path));
    }
}