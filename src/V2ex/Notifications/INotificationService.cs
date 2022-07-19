namespace V2ex.Notifications;

public interface INotificationService
{
    Task<Response<NotificationResponse>?> GetAsync(int p);

    Task DeleteAsync(int id);
}