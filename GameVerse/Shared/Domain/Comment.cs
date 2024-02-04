using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Comment : BaseDomainModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Comment exceeded the length requirement")]
        public string? Text { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Title not meet length requirements")]
        public string? Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }

        [Required]
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }

    }
}
