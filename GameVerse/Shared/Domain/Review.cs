using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameVerse.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        [RegularExpression(@"^([1-9]|10)(\.5)?$", ErrorMessage = "Rating must be a whole number or have a .5 interval")]
        public double ReviewRating {  get; set; }

        [Required]
        [StringLength(400, ErrorMessage = "Review exceeded the length requirement")]
        public string? Text { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }

        [Required]
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }

        [Required]
        public int? GameId { get; set; }
        public virtual Game? Game { get; set; }
    }
}
