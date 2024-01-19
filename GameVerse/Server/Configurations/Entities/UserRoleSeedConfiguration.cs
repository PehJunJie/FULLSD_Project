using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GameVerse.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration :
    IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "b2e72033-bcd7-4862-8f4b-e529252b0201", // Identity Role
                UserId = "f8f4089e-a9a4-440c-bdec-9a615bd72cbd"  // Application User
            }
            );
        }
    }
}
