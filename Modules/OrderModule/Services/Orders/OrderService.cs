using AutoMapper;
using Core.Core;
using Core.Core.Helper;
using Microsoft.EntityFrameworkCore;
using OrderModule.Core;
using OrderModule.Models.OrderItems;
using OrderModule.Models.Orders;
using OrderModule.Models.Orders.Dto;
using OrderModule.Models.Shipments;
using OrderModule.Models.UserModified;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderModule.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkOrder _unitOfWork;
        private readonly OrderDbContext _salesDbContext;
        public OrderService(
            IMapper mapper,
            IUnitOfWorkOrder unitOfWork,
            OrderDbContext salesDbContext
            )
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _salesDbContext = salesDbContext;
        }

       


        public Task<ApiJsonResult> Delete(int id)
        {
            var order = _unitOfWork.OrderRepository.FindAll().Where(x=>x.Id==id);
        }

        public async Task<List<Order>> GetAllOrder()
        {
            var order = _unitOfWork.OrderRepository.FindAll().ToList();
            return order;
        }

        public async Task<List<Order>> GetByFilter(OrderFilter orderFilter)
        {
            var order = _unitOfWork.OrderRepository.FindAll().ToList();
            if(orderFilter.OrderId.HasValue)
            {
                order = order.Where(x => x.Id == orderFilter.OrderId).ToList();
            }
            if (!String.IsNullOrEmpty(orderFilter.CustomerName))
            {
                order = order.Where(x => x.CustomerName == orderFilter.CustomerName).ToList();
            }
            return order;
        }

        public IQueryable<Order> GetById(int id)
        {
            return _unitOfWork.OrderRepository.FindByCondition(p => p.Id == id);
        }

       

        public Task<ApiJsonResult> Update(OrderItemDto data)
        {
            throw new NotImplementedException();
        }

       
    }
}
