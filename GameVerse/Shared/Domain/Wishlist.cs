using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Wishlist : BaseDomainModel
    {
        public string? Games { get; set; }
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
    }
}
