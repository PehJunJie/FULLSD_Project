using Duende.IdentityServer.EntityFramework.Options;
using GameVerse.Server.Configurations.Entities;
using GameVerse.Server.Models;
using GameVerse.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Drawing;

namespace GameVerse.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Forum> Forums { get ; set; }   
        public DbSet<Community> Communities { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CommentSeedConfiguration());

            builder.ApplyConfiguration(new CommunitySeedConfiguration());

            builder.ApplyConfiguration(new ConsumerSeedConfiguration());

            builder.ApplyConfiguration(new GameSeedConfiguration());

            builder.ApplyConfiguration(new OrderSeedConfiguration());

            builder.ApplyConfiguration(new PaymentSeedConfiguration());

            builder.ApplyConfiguration(new RecommendationSeedConfiguration());

            builder.ApplyConfiguration(new ReviewSeedConfiguration());

            builder.ApplyConfiguration(new StoreSeedConfiguration());

            builder.ApplyConfiguration(new WishlistSeedConfiguration());

            builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());

            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }
    }
}
