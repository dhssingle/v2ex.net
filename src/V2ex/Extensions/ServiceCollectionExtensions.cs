using Microsoft.Extensions.DependencyInjection;
using V2ex.Notifications;

namespace V2ex.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddV2ex(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddDistributedMemoryCache();
            services.AddHttpClient<IV2exClient, V2exClient>()
                    .ConfigureHttpClient(c =>
                    {
                        c.BaseAddress = new Uri(" https://www.v2ex.com/");
                    })
                    .AddHttpMessageHandler<AuthHeaderHandler>();

            services.AddTransient<IAuthTokenStore, AuthTokenStore>();
            services.AddTransient<INotificationService, NotificationService>();

            return services;
        }
    }
}
