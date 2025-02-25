namespace Soheil_Imani_EntityFramework_Project.Models.Entity
{
    public class DiscountCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public double DiscountPercentage { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
