using GameVerse.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameVerse.Server.Configurations.Entities
{
    public class ConsumerSeedConfiguration : IEntityTypeConfiguration<Consumer>
    {
        public void Configure(EntityTypeBuilder<Consumer> builder)
        {
            builder.HasData(
                new Consumer
                {
                    Id = 1,

                    Name = "John Smith",
                    UserName = "jsmithy",
                    EmailAddress = "johnsmith@gmail.com",
                    Age = 25,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Consumer
                {
                    Id = 2,

                    Name = "Marry Jones",
                    UserName = "joneygirl",
                    EmailAddress = "marryjones@gmail.com",
                    Age = 22,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
