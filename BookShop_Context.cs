using Microsoft.EntityFrameworkCore;
using Soheil_Imani_EntityFramework_Project.Mapping;
using Soheil_Imani_EntityFramework_Project.Models.Entity;
using System.Reflection.Metadata.Ecma335;

namespace Soheil_Imani_EntityFramework_Project
{
    public class BookShop_Context : DbContext
    {
        public BookShop_Context(DbContextOptions<BookShop_Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source = bookstore.db");
            }
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
        }

        public DbSet<Book> Books{ get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DiscountCode> DiscountCodes { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
