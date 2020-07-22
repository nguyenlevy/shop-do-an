﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Models.Products
{
    [Table("ProductManufacturer")]
    public class ProductManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TenantId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? UserModifiedId { get; set; }
    }
}
