namespace V2ex.Notifications;

public interface INotificationService
{
    Task<Response<NotificationResponse>?> GetNotificationsAsync(int p);

    Task DeletetNotificationsAsync(int id);
}