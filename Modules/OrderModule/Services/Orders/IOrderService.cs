using Core.Core;
using OrderModule.Models.Orders;
using OrderModule.Models.Orders.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderModule.Services.Orders
{
    public interface IOrderService
    {
        Task<List<Order>> GetByFilter(OrderFilter orderFilter);
        Task<ApiJsonResult> Update( OrderItemDto data);
        Task<ApiJsonResult> Delete(int id);
        Task<List<Order>> GetAllOrder();
        IQueryable<Order> GetById(int id);
    }
}
