namespace Soheil_Imani_EntityFramework_Project.Models.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public string ShippingAddress { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

    }
}
