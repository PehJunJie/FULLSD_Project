using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Consumer : BaseDomainModel
    {
        public string? Image {  get; set; }

        [Required]
        [StringLength(70, MinimumLength = 2, ErrorMessage = "Full name does not meet length requirements")]
        public string? Name { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "User name does not meet length requirements")]
        public string? UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Address is not a valid email")]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        [Required]
        [Range(13, 120, ErrorMessage = "Age must be between 13 and 120")]
        public int Age { get; set; }

        public virtual List<Review>? Reviews { get; set; }
        public virtual List<Order>? Orders { get; set; }
        public virtual List<Wishlist> Wishlists { get; set; }
    }
}
