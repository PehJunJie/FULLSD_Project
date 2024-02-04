using GameVerse.Shared.Domain;
using GameVerse.Client.Pages;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameVerse.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Comment> Comments { get; }
        IGenericRepository<Forum> Forums { get; }
        IGenericRepository<Community> Communities { get; }
        IGenericRepository<Consumer> Consumers { get; }
        IGenericRepository<Game> Games { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Recommendation> Recommendations { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<Store> Stores { get; }
        IGenericRepository<Wishlist> Wishlists { get; }
    }
}