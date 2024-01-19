using GameVerse.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameVerse.Server.Configurations.Entities
{
    public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    Id = 1,

                    ReviewRating = 8.0, 
                    Text = "The game provides a lot of freebies, leveling up every quickly without spending money.",
                    ReviewDate = new DateTime(2024, 1, 2), 
                    ConsumerId = 1,
                    GameId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Review
                {
                    Id = 2,

                    ReviewRating = 4.5,
                    Text = "I the game turns out to be pretty bad with frequent bugs.",
                    ReviewDate = new DateTime(2023, 11, 13),
                    ConsumerId = 2,
                    GameId = 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
