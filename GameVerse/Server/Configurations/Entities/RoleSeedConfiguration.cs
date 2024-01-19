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
                    Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR" 
                },
                new IdentityRole // Consumer
                {
                    Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    Name = "User",
                    NormalizedName = "USER"
                }
                );
        }
    }
}
