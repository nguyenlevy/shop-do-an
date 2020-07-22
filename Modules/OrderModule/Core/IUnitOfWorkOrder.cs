using OrderModule.Models.OrderItems;
using OrderModule.Models.Orders;
using OrderModule.Models.PaymentMethods;
using OrderModule.Models.Shipments;
using System.Threading.Tasks;

namespace OrderModule.Core
{
    public interface IUnitOfWorkOrder
    {
        Task Commit();

        GenericRepository<Order> OrderRepository { get; }
        GenericRepository<OrderItem> OrderItemRepository { get; }
        GenericRepository<Transport> TransportRepository { get; }
        GenericRepository<PaymentMethod> PaymentMethodRepository { get; }

    }
}
