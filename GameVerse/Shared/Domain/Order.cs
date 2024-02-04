using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public string? OrderedGames { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Amount paid should contain up to 2 decimal places")]
        public double AmountPaid { get; set; }

        [Required]
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }

        [Required]
        public int? PaymentId { get; set; }
        public virtual Payment? Payment { get; set; }
    }
}
