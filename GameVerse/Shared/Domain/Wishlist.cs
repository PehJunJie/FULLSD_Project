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
        [Required]
        public string? Games { get; set; }

        [Required]
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
    }
}
