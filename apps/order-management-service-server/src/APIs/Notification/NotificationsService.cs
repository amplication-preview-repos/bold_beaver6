using OrderManagementService.Infrastructure;

namespace OrderManagementService.APIs;

public class NotificationsService : NotificationsServiceBase
{
    public NotificationsService(OrderManagementServiceDbContext context)
        : base(context) { }
}
