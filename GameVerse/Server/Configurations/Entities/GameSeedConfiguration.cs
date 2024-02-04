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

                    Image = GetImageData("Images/zelda.jpg"),
                    Title = "The Legend of Zelda: Tears of the Kingdom",
                    OverallRating = 8.4,
                    Genre = "Open-World Action",
                    Developer = "Nintendo",
                    Publisher = "Nintendo",
                    ReleaseDate = new DateTime(2023, 05, 12),
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

                    Image = GetImageData("Images/honkaistarrail.jpg"),
                    Title = "Honkai: Star Rail",
                    OverallRating = 6.5,
                    Genre = "Role-Playing",
                    Developer = "Cognosphere",
                    Publisher = "miHoYo",
                    ReleaseDate = new DateTime(2023, 04, 26),
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

                    Image = GetImageData("Images/forzamotorsport.jpg"),
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
                },
                new Game
                {
                    Id = 4,

                    Image = GetImageData("Images/genshinimpact.jpg"),
                    Title = "Genshin Impact",
                    OverallRating = 5.6,
                    Genre = "Action RPG",
                    Developer = "miHoYo",
                    Publisher = "miHoYo",
                    ReleaseDate = new DateTime(2020, 09, 28),
                    Description = "Explore the vast fantasy world of Teyvat, a land filled with adventure and mysteries. " +
                    "As a traveler from another realm, your quest is to find your lost sibling and uncover Teyvat's secrets. " +
                    "Guided by the kind-hearted sprite Paimon, journey through forests, towns, and dungeons, facing foes and solving puzzles.",
                    Platform = "PlayStation 4/5, iOS, PC, Nintendo Switch",
                    ContentRating = "T",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Game
                {
                    Id = 5,

                    Image = GetImageData("Images/grandtheftautov.jpeg"),
                    Title = "Grand Theft Auto V",
                    OverallRating = 8.4,
                    Genre = "Open-World Action",
                    Developer = "Rockstar North",
                    Publisher = "Rockstar Games",
                    ReleaseDate = new DateTime(2014, 11, 18),
                    Description = "Los Santos, once a thriving metropolis, now grapples with economic uncertainty and the allure of reality TV. " +
                    "In this chaotic environment, three distinct criminals: Franklin, Michael and Trevor band together to execute daring heists, " +
                    "risking everything for a chance at survival and success in a city that has lost its former glory.",
                    Platform = "PlayStation 3/4/5, Xbox 360, Xbox One, PC, Xbox Series X",
                    ContentRating = "M",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Game
                {
                    Id = 6,

                    Image = GetImageData("Images/starfield.jpg"),
                    Title = "Starfield",
                    OverallRating = 7.0,
                    Genre = "sci-fi RPG",
                    Developer = "Bethesda Game Studios",
                    Publisher = "Bethesda Softworks",
                    ReleaseDate = new DateTime(2023, 09, 06),
                    Description = "Starfield is the first new universe in over 25 years from Bethesda Game Studios. " +
                    "In this next generation role-playing game set amongst the stars, create any character you want and " +
                    "explore with unparalleled freedom as you embark on an epic journey to answer humanity’s greatest mystery.",
                    Platform = "PC, Xbox Series X",
                    ContentRating = "M",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Game
                {
                    Id = 7,

                    Image = GetImageData("Images/mariokart8deluxe.jpg"),
                    Title = "Mario Kart 8 Deluxe",
                    OverallRating = 8.6,
                    Genre = "Racing",
                    Developer = "Nintendo",
                    Publisher = "Nintendo",
                    ReleaseDate = new DateTime(2017, 04, 28),
                    Description = "Race and compete against friends in the ultimate edition of Mario Kart 8 on the Nintendo Switch. " +
                    "Experience the definitive version, allowing for gameplay anytime, anywhere. Engage in local multiplayer with up to 4 players in 1080p when in TV mode. " +
                    "Enjoy all tracks from the Wii U version, including DLC, and encounter new guest characters like the Inklings.",
                    Platform = "Nintendo Switch",
                    ContentRating = "E",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }

        // Helper method to convert an image file to a base64 string
        private static string GetImageData(string imagePath)
        {
            using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    byte[] imageBytes = memoryStream.ToArray();
                    return Convert.ToBase64String(imageBytes);
                }
            }
        }
    }
}
