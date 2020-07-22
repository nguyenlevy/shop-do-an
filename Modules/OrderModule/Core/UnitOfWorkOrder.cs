using OrderModule.Models.OrderItems;
using OrderModule.Models.Orders;
using OrderModule.Models.PaymentMethods;
using OrderModule.Models.Shipments;
using System;
using System.Threading.Tasks;

namespace OrderModule.Core
{
    public class UnitOfWorkOrder : IUnitOfWorkOrder, IDisposable
    {
        protected OrderDbContext context = new OrderDbContext();

        public GenericRepository<Order> OrderRepository => new GenericRepository<Order>(context);

        public GenericRepository<PaymentMethod> PaymentMethodRepository => new GenericRepository<PaymentMethod>(context);

        public GenericRepository<OrderItem> OrderItemRepository => new GenericRepository<OrderItem>(context);

        public GenericRepository<Transport> TransportRepository => new GenericRepository<Transport>(context);


        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
