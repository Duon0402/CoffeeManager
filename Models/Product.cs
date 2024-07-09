using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManager.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
