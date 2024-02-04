using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Recommendation : BaseDomainModel
    {
        [Required]
        [Range(1, 3, ErrorMessage = "Rank must be 1, 2 or 3")]
        public int Rank { get; set; }

        [Required]
        public int? GameId { get; set; }
        public virtual Game? Game { get; set; }
    }
}
