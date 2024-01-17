using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVerse.Shared.Domain
{
    public class Payment : BaseDomainModel
    {      
        public string? Method { get; set; }
    }
}
