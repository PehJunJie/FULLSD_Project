using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameVerse.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole // Staff
                {
                    Id = "b2e72033-bcd7-4862-8f4b-e529252b0201",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR" 
                },
                new IdentityRole // Consumer
                {
                    Id = "52791369-72d2-4745-aafa-77a4128b3b61",
                    Name = "User",
                    NormalizedName = "USER"
                }
                );
        }
    }
}
