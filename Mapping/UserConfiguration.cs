using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Soheil_Imani_EntityFramework_Project.Models.Entity;

namespace Soheil_Imani_EntityFramework_Project.Mapping
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u=>u.Id);
            builder.Property(u=>u.FullName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.Property(u => u.Address).IsRequired().HasMaxLength(55);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(25);
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.Role).IsRequired().HasMaxLength(15);

            //builder.HasMany(u=>u.Orders).WithOne(o=)


        }
    }
}
