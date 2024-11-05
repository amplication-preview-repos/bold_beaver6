using OrderManagementService.Infrastructure;

namespace OrderManagementService.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(OrderManagementServiceDbContext context)
        : base(context) { }
}
