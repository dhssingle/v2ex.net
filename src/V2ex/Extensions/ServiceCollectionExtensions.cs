using Microsoft.Extensions.DependencyInjection;
using V2ex.Members;
using V2ex.Nodes;
using V2ex.Notifications;
using V2ex.Tokens;
using V2ex.Topics;

namespace V2ex.Extensions;

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

        services.AddScoped<IAuthTokenStore, AuthTokenStore>();
        services.AddTransient<INotificationService, NotificationService>();
        services.AddTransient<IMemberService, MemberService>();
        services.AddTransient<INodeService, NodeService>();
        services.AddTransient<ITopicService, TopicService>();
        services.AddTransient<ITokenService, TokenService>();

        return services;
    }
}

