﻿using GameVerse.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameVerse.Server.Configurations.Entities
{
    public class OrderSeedConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order
                {
                    Id = 1,

                    OrderDate = new DateTime(2024, 01, 17),
                    OrderedGames = "Forza Horizon 5, NBA 2K24",
                    AmountPaid = 100.50, 
                    ConsumerId = 1,
                    PaymentId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Order
                {
                    Id = 2,

                    OrderDate = new DateTime(2024, 01, 18),
                    OrderedGames = "Borderslands 3, BOKURA",
                    AmountPaid = 16.30,
                    ConsumerId = 2,
                    PaymentId = 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Order
                {
                    Id = 3,

                    OrderDate = new DateTime(2024, 01, 22),
                    OrderedGames = "Marvel's Spider-Man 2",
                    AmountPaid = 69.99,
                    ConsumerId = 4,
                    PaymentId = 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Order
                {
                    Id = 4,

                    OrderDate = new DateTime(2024, 01, 30),
                    OrderedGames = "Tekken 8, PUBG, Super Smash Bros. Ultimate",
                    AmountPaid = 245.99,
                    ConsumerId = 5,
                    PaymentId = 4,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
