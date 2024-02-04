using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Forum : BaseDomainModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Forum title too long")]
        public string? Topic { get; set; }

        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
        //public virtual Comment? Comments { get; set; }

    }
}
