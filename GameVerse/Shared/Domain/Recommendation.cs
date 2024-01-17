using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Recommendation : BaseDomainModel
    {
        public int Rank { get; set; }
        public int? GameId { get; set; }
        public virtual Game? Game { get; set; }
    }
}
