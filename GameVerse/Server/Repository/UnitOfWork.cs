using GameVerse.Server.Data;
using GameVerse.Server.IRepository;
using GameVerse.Server.Models;
using GameVerse.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GameVerse.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Comment> _comments;
        private IGenericRepository<Forum> _forums;
        private IGenericRepository<Community> _communities;
        private IGenericRepository<Consumer> _consumers;
        private IGenericRepository<Game> _games;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<Payment> _payments;
        private IGenericRepository<Recommendation> _recommendations;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<Store> _stores; 
        private IGenericRepository<Wishlist> _wishlists;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Comment> Comments
            => _comments ??= new GenericRepository<Comment>(_context);
        public IGenericRepository<Forum> Forums
            => _forums ??= new GenericRepository<Forum>(_context);
        public IGenericRepository<Community> Communities
            => _communities ??= new GenericRepository<Community>(_context);
        public IGenericRepository<Consumer> Consumers
            => _consumers ??= new GenericRepository<Consumer>(_context);
        public IGenericRepository<Game> Games
            => _games ??= new GenericRepository<Game>(_context);
        public IGenericRepository<Order> Orders
            => _orders ??= new GenericRepository<Order>(_context);
        public IGenericRepository<Payment> Payments
            => _payments ??= new GenericRepository<Payment>(_context);
        public IGenericRepository<Recommendation> Recommendations
            => _recommendations ??= new GenericRepository<Recommendation>(_context);
        public IGenericRepository<Review> Reviews
            => _reviews ??= new GenericRepository<Review>(_context);
        public IGenericRepository<Store> Stores
            => _stores ??= new GenericRepository<Store>(_context);
        public IGenericRepository<Wishlist> Wishlists
            => _wishlists ??= new GenericRepository<Wishlist>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}