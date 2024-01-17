using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public DateTime OrderDate { get; set; }
        public string? OrderedGames { get; set; }
        public int AmountPaid { get; set; }
        public int? ConsumerId { get; set; }
        public virtual Consumer? Consumer { get; set; }
        public int? PaymentId { get; set; }
        public virtual Payment? Payment { get; set; }
    }
}
