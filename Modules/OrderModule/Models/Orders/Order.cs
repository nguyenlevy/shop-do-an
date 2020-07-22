using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderModule.Models.Orders
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public decimal Price { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int TransportId { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? UserModifiedId { get; set; }
        //public int Id { get; set; }
        //public int? StoreId { get; set; }
        //public Store Store { get; set; }
        //public int CustomerId { get; set; }
        //public Customer Customer { get; set; }
        //public OrderStatus OrderStatusId { get; set; }
        //[Column(TypeName = "decimal(18, 4)")]
        //public decimal OrderTax { get; set; }
        //[Column(TypeName = "decimal(18, 4)")]
        //public decimal OrderDiscount { get; set; }
        //[Column(TypeName = "decimal(18, 4)")]
        //public decimal OrderTotal { get; set; }
        //public int TenantId { get; set; }
        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal? OrderDebt { get; set; }
        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal? OrderPaid { get; set; }
        //public string OrderCode { get; set; }
        //public int? PaymentMethodId { get; set; }
        //public PaymentMethod PaymentMethod { get; set; }
        //public DateTime? SaleDate { get; set; }
        //public int? SellerId { get; set; }
        //public Employee Seller { get; set; }
        //public ICollection<OrderItem> OrderItems { get; set; }
        ////public OrderNote OrderNote { get; set; }
        //public Shipment Shipment { get; set; }
        //public DateTime? CreatedDate { get; set; }
        //public DateTime? ModifiedDate { get; set; }
        //public long? UserModifiedId { get; set; }
        //public OrderType? OrderType { get; set; }
        //public virtual OrderNote OrderNote { get; set; }
    }
}
