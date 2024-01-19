using GameVerse.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameVerse.Server.Configurations.Entities
{
    public class GameSeedConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                new Game
                {
                    Id = 1,

                    Title = "The Legend of Zelda: Tears of the Kingdom",
                    OverallRating = 8.4,
                    Genre = "Open-World Action",
                    Developer = "Nintendo",
                    Publisher = "Nintendo",
                    ReleaseDate = new DateTime(2023, 5, 12),
                    Description = "A sequel to The Legend of Zelda: Breath of the Wild. " +
                    "The game lets you explore a large and diverse world of Hyrule and its mysterious islands. " +
                    "You can choose your own adventure and use Link’s new abilities to fight back against the malevolent forces.",
                    Platform = "Nintendo Switch",
                    ContentRating = "E10+",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Game
                {
                    Id = 2,

                    Title = "Honkai: Star Rail",
                    OverallRating = 6.5,
                    Genre = "Role-Playing",
                    Developer = "Cognosphere",
                    Publisher = "miHoYo",
                    ReleaseDate = new DateTime(2023, 4, 26),
                    Description = "A space sci-fi role-playing game that combines myths and legends with exploration and combat. " +
                    "Players will board the Astral Express and visit different worlds, meet companions, and resolving [Stellaron]-related conflicts. " +
                    "The game has a simple and strategic combat system and large maps with puzzles and surprises.",
                    Platform = "PC, iOS, Android, PlayStation 5",
                    ContentRating = "T",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Game
                {
                    Id = 3,

                    Title = "Forza Motorsport Standard Edition",
                    OverallRating = 7.5,
                    Genre = "Racing Sim",
                    Developer = "Turn 10",
                    Publisher = "Xbox Game Studios",
                    ReleaseDate = new DateTime(2023, 10, 10),
                    Description = "Out-build the competition in the all-new career. Race your friends in adjudicated multiplayer events. " +
                    "Compete in over 500 cars on world-famous tracks with cutting edge AI, advanced physics, and tire and fuel strategy.",
                    Platform = "PC, Xbox Series X",
                    ContentRating = "E",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
