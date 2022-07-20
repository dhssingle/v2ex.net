namespace V2ex.Notifications;

public interface INotificationService
{
    Task<NotificationsResponse?> GetListAsync(int p);

    Task DeleteAsync(int id);
}