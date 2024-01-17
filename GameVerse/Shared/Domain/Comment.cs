using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Comment : BaseDomainModel
    {
        public string? Text { get; set; }
        public DateTime CommentDate { get; set; }
        public int? ConsumerID { get; set; }
        public virtual Consumer? Consumer { get; set; }
        public int? CommunityId { get; set; }
        public virtual Community? Community { get; set; }
    }
}
