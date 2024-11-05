using Microsoft.AspNetCore.Mvc;

namespace OrderManagementService.APIs;

[ApiController()]
public class NotificationsController : NotificationsControllerBase
{
    public NotificationsController(INotificationsService service)
        : base(service) { }
}
