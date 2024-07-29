using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace assignment3.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public List<int> ProductIds { get; set; } = new List<int>();

        [Required]
        public int Quantity { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public string ShippingAddress { get; set; } = string.Empty;

        [Required]
        public decimal TotalAmount { get; set; }  
    }
}
