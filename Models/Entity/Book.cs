namespace Soheil_Imani_EntityFramework_Project.Models.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public int PublisherYear { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; }
        public double Rating { get; set; }

        public Author Author { get; set; }
        public Category? Category { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<Review> Review { get; set; } = new List<Review>();
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
