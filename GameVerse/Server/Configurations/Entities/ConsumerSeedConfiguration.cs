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

                    Image = GetImageData("Images/haloinfinite.jpg"),
                    Name = "John Smith",
                    UserName = "jsmithy",
                    EmailAddress = "johnsmithy@gmail.com",
                    Age = 28,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Consumer
                {
                    Id = 2,

                    Image = GetImageData("Images/cartoonfries.jpeg"),
                    Name = "Marry Jones",
                    UserName = "joneygirl",
                    EmailAddress = "marry4jones@gmail.com",
                    Age = 22,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Consumer
                {
                    Id = 3,

                    Image = GetImageData("Images/porsche911gt3rs.jpg"),
                    Name = "Mat Watson",
                    UserName = "Matthewcars",
                    EmailAddress = "matwaston@outlook.com",
                    Age = 36,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }, 
                new Consumer
                {
                    Id = 4,
                    
                    Image = GetImageData("Images/defaultprofile.jpeg"),
                    Name = "Sophia Chang",
                    UserName = "soapgamer",
                    EmailAddress = "sophiachang@gmail.com",
                    Age = 20,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Consumer
                {
                    Id = 5,

                    Image = GetImageData("Images/gamefox.jpg"),
                    Name = "Paul Russell",
                    UserName = "pau1op",
                    EmailAddress = "paulrussell24@gmail.com",
                    Age = 25,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Consumer
                {
                    Id = 6,

                    Image = GetImageData("Images/eevee_pokemon.jpg"),
                    Name = "Angelica Jones",
                    UserName = "niceangel",
                    EmailAddress = "angelicajones37@outlook.com",
                    Age = 27,

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
