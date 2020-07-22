using System;
using System.Collections.Generic;
using System.Text;

namespace WebClientService.Models.Dto
{
   public class OrderDto
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public decimal Price { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int TransportId { get; set; }
        public string Note { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
