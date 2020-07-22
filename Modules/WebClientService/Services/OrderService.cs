using AutoMapper;
using Core.Core;
using Core.Core.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebClient.Core;
using WebClientService.Models;
using WebClientService.Models.Dto;

namespace WebClientService.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWorkWebClient _unitOfWork;
        private readonly WebClientDbContext _dbContext;
        private readonly IMapper _mapper;
        public OrderService(
            IUnitOfWorkWebClient unitOfWork,
            WebClientDbContext dbContext,
        IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async Task<ApiJsonResult> Create(Order data)
        {
            var result = new ApiJsonResult();
            var objOrder = new Order
            {
                Id=data.Id,
                Address = data.Address,
                CustomerName = data.CustomerName,
                Note = data.Note,
                PhoneNumber = data.PhoneNumber,
                OrderCode = Constants.GenerateCode(),
                Price = data.Price,
                TransportId = 1,
                CreatedDate =DateTime.Now
            };
            _dbContext.Order.Add(objOrder);
            _dbContext.SaveChanges();
            var test = objOrder.Id;
            foreach(var item in data.OrderItem)
            {
                var objOrderItem = new OrderItem
                {
                    ProductId= item.ProductId,
                    Number =item.Number,
                    OrderId = objOrder.Id
                  
                };
                _dbContext.OrderItem.Add(objOrderItem);
            }
            _dbContext.SaveChanges();
            return result;
        }
    }
}
