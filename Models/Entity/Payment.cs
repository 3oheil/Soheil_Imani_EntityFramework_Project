namespace Soheil_Imani_EntityFramework_Project.Models.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string TransationId { get; set; }
        public DateTime PaymantDate { get; set; }
    }
}
