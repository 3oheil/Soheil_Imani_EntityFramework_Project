using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Soheil_Imani_EntityFramework_Project.Models.Entity;

namespace Soheil_Imani_EntityFramework_Project.Mapping
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a=>a.FullName).IsRequired().HasMaxLength(128);
            builder.Property(a=>a.Biography).HasMaxLength(1000).HasColumnType("text");


        }
    }
}
