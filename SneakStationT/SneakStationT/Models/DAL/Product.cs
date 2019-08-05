using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SneakStationT.Models.DAL
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public double Price { get; set; }
        public string ProductDetail { get; set; }
        public int Quantity { get; set; }
        public int Order { get; set; }
        public bool isNew { get; set; }
        public bool isActive { get; set; }
    }
}