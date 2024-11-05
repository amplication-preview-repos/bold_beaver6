using Microsoft.AspNetCore.Mvc;
using OrderManagementService.APIs.Common;
using OrderManagementService.Infrastructure.Models;

namespace OrderManagementService.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class OrderFindManyArgs : FindManyInput<Order, OrderWhereInput> { }
