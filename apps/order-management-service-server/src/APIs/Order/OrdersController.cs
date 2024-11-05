using Microsoft.AspNetCore.Mvc;

namespace OrderManagementService.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
