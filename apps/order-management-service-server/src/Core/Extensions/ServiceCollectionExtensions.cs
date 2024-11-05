using OrderManagementService.APIs;

namespace OrderManagementService;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<INotificationsService, NotificationsService>();
        services.AddScoped<IOrdersService, OrdersService>();
        services.AddScoped<IUsersService, UsersService>();
    }
}
