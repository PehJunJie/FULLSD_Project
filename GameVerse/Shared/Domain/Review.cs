using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public double ReviewRating {  get; set; }
        public string? Text { get; set; }
        public DateTime ReviewDate { get; set; }
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
        public int? GameId { get; set; }
        public virtual Game? Game { get; set; }
    }
}
