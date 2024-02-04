using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Community : BaseDomainModel
    {
        [Required]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Name not meet length requirements")]
        public string? Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Description does not meet length requirements")]
        public string? Description { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "There must be at least 1 or more members")]
        public int MemberCount { get; set; }
    }
}
