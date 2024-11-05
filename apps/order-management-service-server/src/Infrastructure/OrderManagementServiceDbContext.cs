using Microsoft.EntityFrameworkCore;
using OrderManagementService.Infrastructure.Models;

namespace OrderManagementService.Infrastructure;

public class OrderManagementServiceDbContext : DbContext
{
    public OrderManagementServiceDbContext(
        DbContextOptions<OrderManagementServiceDbContext> options
    )
        : base(options) { }

    public DbSet<OrderDbModel> Orders { get; set; }

    public DbSet<NotificationDbModel> Notifications { get; set; }

    public DbSet<UserDbModel> Users { get; set; }
}
