namespace Soheil_Imani_EntityFramework_Project.Models.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Review> Review { get; set; } = new List<Review>();
    }
}
