using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Soheil_Imani_EntityFramework_Project.Models.Entity;

namespace Soheil_Imani_EntityFramework_Project.Mapping
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b=>b.Title).IsRequired().HasMaxLength(50);
            builder.Property(b => b.ISBN).IsRequired().HasMaxLength(50);
            builder.Property(b => b.Price).IsRequired().HasColumnType("decimal(18, 2)");
            builder.Property(b => b.StockQuantity).IsRequired().HasMaxLength(20);
            builder.Property(b => b.CategoryId).IsRequired();
            builder.Property(b => b.PublisherYear).IsRequired();
            builder.Property(b => b.PublisherId).IsRequired();
            builder.Property(b => b.Language).IsRequired().HasMaxLength(50);
            builder.Property(b => b.Description).HasColumnType("Text").HasMaxLength(500);

            builder.HasOne(b=>b.Author).WithMany(a=>a.Books).HasForeignKey(b=>b.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c=>c.Category).WithMany(a=>a.Books).HasForeignKey(b=>b.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(b => b.Publisher).WithMany(p=>p.Books).HasForeignKey(b=>b.PublisherId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
