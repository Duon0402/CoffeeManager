using CoffeeManager.Models.Employees;

namespace CoffeeManager.Models
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime OrderDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Employee Employee { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public decimal TotalAmount => OrderDetails.Sum(i => i.TotalPrice);
    }
}
