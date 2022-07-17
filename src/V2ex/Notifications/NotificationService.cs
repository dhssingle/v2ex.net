namespace V2ex.Notifications;

public class NotificationService : INotificationService
{
    protected IV2exClient V2exClient { get; }

    public NotificationService(IV2exClient v2exClient)
    {
        V2exClient = v2exClient;
    }

    public async Task<Response<NotificationResponse>?> GetNotificationsAsync(int p)
    {
        var path = $"api/v2/notifications?p={p}";

        return await V2exClient.SendAsync<Response<NotificationResponse>>(new HttpRequestMessage(HttpMethod.Get, path));
    }

    public async Task DeletetNotificationsAsync(int id)
    {
        var path = $"api/v2/notifications/{id}";

        await V2exClient.SendAsync<Response>(new HttpRequestMessage(HttpMethod.Delete, path));
    }
}