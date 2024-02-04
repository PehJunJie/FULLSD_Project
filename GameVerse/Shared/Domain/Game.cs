using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Game : BaseDomainModel
    {
        public string? Image { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        [RegularExpression(@"^([1-9]|10)(\.5)?$", ErrorMessage = "Rating must be a whole number or have a .5 interval")]
        public double OverallRating { get; set; }

        [Required]
        public string? Genre { get; set; }

        [Required]
        public string? Developer { get;set; }

        [Required]
        public string? Publisher { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(400, ErrorMessage = "Description exceeded the length requirement")]
        public string? Description { get; set; }

        [Required]
        public string? Platform { get; set; }

        [Required]
        public string? ContentRating { get; set; }
        public virtual List<Recommendation>? Recommedations { get; set; }
        public virtual List<Store>? Stores { get; set; }
        public virtual List<Review>? Reviews { get; set; }
    }
}
