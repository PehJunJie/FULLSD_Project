﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Store : BaseDomainModel
    {
        public int OriginalPrice { get; set; }
        public int DiscountedPrice { get; set; }
        public Boolean Subscription { get; set; }
        public string? AvailabilityStatus { get; set; }
        public int? GameId { get; set; }
        public virtual Game? Game { get; set; }
    }
}