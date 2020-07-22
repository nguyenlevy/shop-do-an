using System;
using System.Collections.Generic;
using System.Text;

namespace WebClientService.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Number { get; set; }
    }
}
