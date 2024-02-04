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
                    Text = "The game design is very different from Breath of the Wild. With Tears of the Kingdom, " +
                    "creativity and appropriation of space are highlighted in an unparalleled way in an open world game.",
                    ReviewDate = new DateTime(2024, 01, 02), 
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

                    ReviewRating = 7.5,
                    Text = "The combat is pretty fun, but it's still just another gacha game at the end of the day. " +
                    "If you're cool with that, you'll probably love it.",
                    ReviewDate = new DateTime(2023, 11, 13),
                    ConsumerId = 2,
                    GameId = 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Review
                {
                    Id = 3,

                    ReviewRating = 4.5,
                    Text = "I knew about this game for a very very long time, but somehow had no urge to play it. " +
                    "But today i did, and boy it was disappointing. Maybe ps4 first party studios spoiled me or something. ",
                    ReviewDate = new DateTime(2023, 11, 13),
                    ConsumerId = 5,
                    GameId = 5,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
