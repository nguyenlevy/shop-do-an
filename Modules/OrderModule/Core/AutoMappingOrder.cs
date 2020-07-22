using AutoMapper;
using OrderModule.Models.Orders;
using OrderModule.Models.Orders.Dto;
using OrderModule.Models.PaymentMethods;
using OrderModule.Models.PaymentMethods.Dto;

namespace OrderModule.Core
{
    public class AutoMappingOrder : Profile
    {
        public AutoMappingOrder()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
            CreateMap<PaymentMethod, PaymentMethodDto>();
        }
    }
}
