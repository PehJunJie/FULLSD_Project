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
        public string? Image { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Community Name does not meet length requirements")]
        public string? Name { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "Description does not meet length requirements")]
        public string? Description { get; set; }
        public int MemberCount { get; set; }
        public bool IsJoined { get; set; } = false;
    }
}
