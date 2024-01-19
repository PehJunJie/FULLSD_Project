using GameVerse.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameVerse.Server.Configurations.Entities
{
    public class CommunitySeedConfiguration : IEntityTypeConfiguration<Community>
    {
        public void Configure(EntityTypeBuilder<Community> builder)
        {
            builder.HasData(
                new Community
                {
                    Id = 1,
                    
                    Name = "Star Rail Official",
                    Description = "Join us for all things Star Rail!",
                    MemberCount = 1530524,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Community
                {
                    Id = 2,

                    Name = "Overwatch Community",
                    Description = "Discuss all things Overwatch.",
                    MemberCount = 127402,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
