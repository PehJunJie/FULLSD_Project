using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Store : BaseDomainModel, IValidatableObject
    {
        [Required]
        [DataType(DataType.Currency)]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Price should contain up to 2 decimal places")]
        public double OriginalPrice { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Price should contain up to 2 decimal places")]
        public double DiscountedPrice { get; set; }

        [Required]
        public Boolean Subscription { get; set; }

        [Required]
        public string? AvailabilityStatus { get; set; }

        [Required]
        public int? GameId { get; set; }
        public virtual Game? Game { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (OriginalPrice < DiscountedPrice)
            {
                yield return new ValidationResult("Original Price must be greater than or same as Discounted Price", new[] { "DiscountedPrice" });
            }
        }
    }
}
