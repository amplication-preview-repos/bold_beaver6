using OrderManagementService.Infrastructure;

namespace OrderManagementService.APIs;

public class UsersService : UsersServiceBase
{
    public UsersService(OrderManagementServiceDbContext context)
        : base(context) { }
}
