using GameVerse.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameVerse.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "f8f4089e-a9a4-440c-bdec-9a615bd72cbd",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                }
                );
        }
    }
}
