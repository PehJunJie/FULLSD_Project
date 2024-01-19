using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Consumer : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? EmailAddress { get; set; }
        public int Age { get; set; }
        public virtual List<Wishlist>? Wishlists { get; set; }
        public virtual List<Review>? Reviews { get; set; }
        public virtual List<Order>? Orders { get; set; }
    }
}
