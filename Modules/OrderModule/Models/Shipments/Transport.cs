using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderModule.Models.Shipments
{
    [Table("Transport")]
    public class Transport
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
