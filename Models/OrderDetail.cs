using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.Models
{
    public class OrderDetail
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Product.UnitPrice * Quantity;
    }
}
