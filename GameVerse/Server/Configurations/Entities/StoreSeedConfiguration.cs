using GameVerse.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameVerse.Server.Configurations.Entities
{
    public class StoreSeedConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasData(
                new Store
                {
                    Id = 1,

                    OriginalPrice = 69.99,
                    DiscountedPrice = 57.00,
                    Subscription = true,
                    AvailabilityStatus = "Not Available",
                    GameId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Store
                {
                    Id = 2,

                    OriginalPrice = 99.90, 
                    DiscountedPrice = 79.92,
                    Subscription = true,
                    AvailabilityStatus = "Available",
                    GameId = 3,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Store
                {
                    Id = 3,

                    OriginalPrice = 29.99,
                    DiscountedPrice = 21.99,
                    Subscription = false,
                    AvailabilityStatus = "Available",
                    GameId = 5,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Store
                {
                    Id = 4,

                    OriginalPrice = 69.99,
                    DiscountedPrice = 69.99,
                    Subscription = false,
                    AvailabilityStatus = "Not Available",
                    GameId = 6,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Store
                {
                    Id = 5,

                    OriginalPrice = 59.99,
                    DiscountedPrice = 53.99,
                    Subscription = true,
                    AvailabilityStatus = "Available",
                    GameId = 7,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
