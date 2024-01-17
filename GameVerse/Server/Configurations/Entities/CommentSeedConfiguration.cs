using GameVerse.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace GameVerse.Server.Configurations.Entities
{
    public class CommentSeedConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment
                {
                    Id = 1,
                    Text = "I love playing Honkai: Star Rail!",
                    CommentDate = new DateTime(2024, 1, 16),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Comment
                {
                    Id = 2,
                    Text = "LE SSERAFIM x Overwatch2 collab is sick!",
                    CommentDate = new DateTime(2024, 1, 17),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
